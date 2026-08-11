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
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            

            btnGuardarRegistro.Enabled = false;

            foreach (Familia f in GestionRoles.Familias)
            {
                cmbRo1.Items.Add(f.Descripcion);
            }

            cmbRo1.DropDownStyle =
                ComboBoxStyle.DropDownList;

            chkAlta.Enabled = false;

            chkBaja.Enabled = false;

            chkModificar.Enabled = false;

            chkLista.Enabled = false;

            chkBuscar.Enabled = false;
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            string nombre = txtNuevoUser.Text;

            string clave = txtNuevaPass.Text;

            string pais = txtNuevoPais.Text;

            if (string.IsNullOrWhiteSpace(nombre)
                || string.IsNullOrWhiteSpace(clave)
                || string.IsNullOrWhiteSpace(pais))
            {
                MessageBox.Show(
                    "Por favor, completa todos los campos para registrarte.",
                    "Datos Incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!GestionUsuarios.EsClaveSegura(clave))
            {
                MessageBox.Show(
                    "La contraseña debe tener:\n" +
                    "- mínimo 8 caracteres\n" +
                    "- una mayúscula\n" +
                    "- un número",
                    "Contraseña insegura",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (GestionUsuarios.ExisteUsuario(nombre))
            {
                MessageBox.Show(
                    "Ese nombre de usuario ya existe.",
                    "Usuario duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            UsuarioFinal nuevoUser =
                new UsuarioFinal(
                    nombre,
                    clave,
                    pais);

            Familia seleccionada =
                GestionRoles.Familias.FirstOrDefault(
                    f => f.Descripcion == cmbRo1.Text);

            nuevoUser.MiFamilia =
                seleccionada;

            if (GestionUsuarios.Registrar(nuevoUser))
            {


                GestorArchivos ga = new GestorArchivos();

                ga.escribir(
                    "usuarios.csv",
                    txtNuevoUser.Text + ";" +
                    nuevoUser.ClaveUsuario + ";" +
                    txtNuevoPais.Text+ ";"+cmbRo1.Text);

                MessageBox.Show(
                    "¡Usuario creado correctamente! Ahora podés iniciar sesión.",
                    "Registro Exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            chkAlta.Checked = false;

            chkBaja.Checked = false;

            chkModificar.Checked = false;

            chkLista.Checked = false;

            chkBuscar.Checked = false;


            

            if (cmbRo1.Text == "Administrador")
            {
                chkAlta.Checked = true;

                chkBaja.Checked = true;

                chkModificar.Checked = true;

                chkLista.Checked = true;

                chkBuscar.Checked = true;
            }


           

            if (cmbRo1.Text == "Usuario")
            {
                chkAlta.Checked = true;

                chkBuscar.Checked = true;
            }


           

            if (cmbRo1.Text == "Superusuario")
            {
                chkAlta.Checked = true;

                chkLista.Checked = true;

                chkBuscar.Checked = true;
            }


            

            if (cmbRo1.Text == "Visitante")
            {
                chkBuscar.Checked = true;
            }


           

            if (cmbRo1.Text == "Cliente")
            {
                chkLista.Checked = true;

                chkBuscar.Checked = true;
            }
        }

        private void txtNuevoUser_Leave(object sender, EventArgs e)
        {
            validarControles();
        }

        private void validarControles()
        {
            if (txtNuevoUser.Text != "" && txtNuevaPass.Text != "" && txtNuevaPass.Text != "" && cmbRo1.SelectedIndex != 0)
            {
                btnGuardarRegistro.Enabled = true;

            }
        }
        
        

        private void txtNuevaPass_Leave(object sender, EventArgs e)
        {
            validarControles();
        }

        private void txtNuevoPais_Leave(object sender, EventArgs e)
        {
            validarControles();
        }

        private void cmbRo1_Leave(object sender, EventArgs e)
        {
            validarControles();
        }

        private void txtNuevoPais_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
