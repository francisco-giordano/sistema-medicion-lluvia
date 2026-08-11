using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyeto_Medicios_de_LLuvia
{
    public partial class Form1 : Form
    {
        private UsuarioFinal UsuarioLogueado;
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        {
            if (GestionUsuarios.UsuarioLogueado != null)
            {
                if (GestionUsuarios.UsuarioLogueado.MiFamilia == null || GestionUsuarios.UsuarioLogueado.MiFamilia.Descripcion != "Administrador")
                {
                    // Oculta las pestañas. Al sacar la primera, el sistema 
                    // automáticamente salta a "Consultas" (que pasa a ser la nueva primera)
                    RegistrarMedicion.TabPages.Remove(RegistrarMedicionn);
                    RegistrarMedicion.TabPages.Remove(tabPageMax);
                    
                }
            }
        }
        string[] localidades =
            {
                 "Avellaneda",
                 "Lanús",
                 "Lomas de Zamora",
                 "Banfield",
                 "Temperley",
                 "Adrogué",
                 "Burzaco",
                 "Claypole",
                 "Longchamps",
                 "Rafael Calzada",
                 "Glew",
                 "Ezeiza",
                 "Monte Grande",
                 "Luis Guillón",
                 "El Jagüel",
                 "Quilmes",
                 "Bernal",
                 "Ezpeleta",
                 "Berazategui",
                 "Florencio Varela",
                 "San Vicente",
                 "Presidente Perón",
                    "Cañuelas"
            };


                foreach (string localidad in localidades)
                {
                    cmbLocalidad.Items.Add(localidad);
                    cmbELocalidad.Items.Add(localidad);
                }

                cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbELocalidad.DropDownStyle = ComboBoxStyle.DropDownList;

                cmbLocalidad.SelectedIndex = 0;
                cmbELocalidad.SelectedIndex = 0;
            }

        

        private void RegistrarMedicion_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (GestionUsuarios.UsuarioLogueado != null)
            {
                
                if (GestionUsuarios.UsuarioLogueado.MiFamilia == null || GestionUsuarios.UsuarioLogueado.MiFamilia.Descripcion != "Administrador")
                {
                    
                    if (e.TabPage == RegistrarMedicionn || e.TabPage == tabPageconsultas || e.TabPage == tabPageMax)
                    {
                        
                        e.Cancel = true;

                        
                        MessageBox.Show("Tu tipo de usuario no tiene permisos para acceder a esta sección.",
                                        "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAgua.Text) ||
                string.IsNullOrWhiteSpace(txtResponsable.Text)||
                cmbLocalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            double cantidad;

            if(!double.TryParse(txtAgua.Text, out cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }
            //objeto

            MedicionLluvia nueva = new MedicionLluvia();

            nueva.FechaHora = dtpFecha.Value;
            nueva.Localidad = cmbLocalidad.Text;
            nueva.CantAgua = cantidad;
            nueva.Responsable = txtResponsable.Text;

            //registrar
            if(SistLLuvia.RegistrarMedicion(nueva))
            {
                GestorArchivos ga = new GestorArchivos();

                ga.escribir(
                    "Mediciones.csv",
                    nueva.FechaHora + ";" +
                    nueva.Localidad + ";" +
                    nueva.CantAgua + ";" +
                    nueva.Responsable);

                MessageBox.Show("Medicion registrada correctamente");

                //limpiar controles

                txtAgua.Clear();

                txtResponsable.Clear();

                cmbLocalidad.SelectedIndex = -1;

                dtpFecha.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("No se pudo registrar la medicion");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstMostrarConsulta.Items.Clear();

            List<MedicionLluvia> consulta =
                SistLLuvia.ConsultarMediciones(
                        dtpDesdeQueFecha.Value,
                        dtpHastaQueFecha.Value,
                        cmbELocalidad.Text);

            if (consulta.Count == 0)
            {
                lstMostrarConsulta.Items.Add("No se encontraron mediciones.");
                return;
            }

            foreach (MedicionLluvia med in consulta)
            {
                lstMostrarConsulta.Items.Add(
                    $"{med.FechaHora:dd/MM/yyyy HH:mm} - " +
                    $"{med.Localidad} - " +
                    $"{med.CantAgua} mm - " +
                    $"{med.Responsable}");

            }

        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            MedicionLluvia resultado =
            SistLLuvia.ObtenerMayorRegistro(
            (int)nudMaximo.Value);

            if (resultado == null)
            {
                MessageBox.Show(
                    "No existen mediciones para esa hora.");

                return;
            }

            MessageBox.Show(
                "Localidad: " + resultado.Localidad +
                "\nCantidad: " + resultado.CantAgua + " mm" +
                "\nFecha: " + resultado.FechaHora +
                "\nResponsable: " + resultado.Responsable);
        }

        private void btnAlertas_Click(object sender, EventArgs e)
        {
            dgvAlertas.Rows.Clear();

            var alertas =
                SistLLuvia.GenerarAlertas();

            foreach (var alerta in alertas)
            {
                dgvAlertas.Rows.Add(
                    alerta.Medicion.Localidad,
                    alerta.Medicion.FechaHora.ToShortDateString(),
                    alerta.Medicion.FechaHora.ToShortTimeString(),
                    alerta.Medicion.CantAgua,
                    alerta.Diferencia,
                    alerta.Estado);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvListaTotal.Rows.Clear();

            List<MedicionLluvia> lista =
                SistLLuvia.ObtenerTodas();

            foreach (MedicionLluvia med in lista)
            {
                dgvListaTotal.Rows.Add(
                    med.Localidad,
                    med.FechaHora.ToShortDateString(),
                    med.FechaHora.ToShortTimeString(),
                    med.CantAgua,
                    med.Responsable);
            }
        }

        private void btnOrdenarLLuvia_Click(object sender, EventArgs e)
        {
            List<MedicionLluvia> lista = SistLLuvia.ObtenerTodas();

            // 2. ¡ACÁ ESTÁ LA MAGIA! 
            // Al usar Sort(), el sistema usa tu IComparable para ordenar todo por cantidad de agua.
            lista.Sort();

            // 3. Mostramos la lista ordenada (por ejemplo, en un cuadro de texto o listbox)
            textBox1.Clear();
            foreach (MedicionLluvia med in lista)
            {
                textBox1.AppendText($"{med.Localidad}: {med.CantAgua} mm\n");
            }
        }
    }
}































































































