using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Proyeto_Medicios_de_LLuvia
{
    public partial class FormLog : Form
    {
        const string CLAVE_ADMIN = "ADMIN2025";

        public FormLog()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            GestionRoles.IniciarRoles();

            GestorArchivos ga = new GestorArchivos();
            ga.CargarUsuariosMemoria();
            
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtUserLogin.Text;
            string clave = txtPassLogin.Text;

            
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (GestionUsuarios.ValidarLogin(nombre, clave))
            {
                Usuario logueado = GestionUsuarios.Buscar(nombre);

                GestionUsuarios.UsuarioLogueado = logueado;

                MessageBox.Show($"¡Bienvenido {logueado.NombreUsuario}!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 formedicion = new Form1();

                formedicion.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPassLogin.Clear();
                txtPassLogin.Focus(); 
            }
        }
        private void txtClaveAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada fue "Enter" (código 13)
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Como ya presionó Enter, el texto en el TextBox está completo
                if (txtUserLogin.Text == CLAVE_ADMIN)
                {
                    UsuarioFinal admin = new UsuarioFinal("Administrador", "", "");
                    admin.MiFamilia = GestionRoles.Familias.FirstOrDefault(f => f.Descripcion == "Administrador");

                    FormPrincipal frm = new FormPrincipal();
                    frm.Show();
                    this.Hide();
                }

                // Opcional: Evita que suene el "beep" de Windows al presionar Enter
                e.Handled = true;
            }
           
        }
      
        private void btnIrARegistro_Click_1(object sender, EventArgs e)
        {
            FormMail ventanaDeSolicitud = new FormMail();

            ventanaDeSolicitud.ShowDialog();
        }
        private void btnRecuClave_Click(object sender, EventArgs e)
        {
           
            FormRecuClave ventanaDeRecuClave = new FormRecuClave();

            ventanaDeRecuClave.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogOut ventanaCerrarSesion = new FormLogOut();

            ventanaCerrarSesion.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormLog_Leave(object sender, EventArgs e)
        {

        }

        private void txtUserLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
