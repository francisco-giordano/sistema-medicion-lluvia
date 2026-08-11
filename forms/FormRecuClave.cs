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
    public partial class FormRecuClave : Form
    {
        public FormRecuClave()
        {
            InitializeComponent();
        }

        private void FormRecuClave_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuarioRecuperar.Text;

            
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
                return;
            }

            
            string claveEncontrada = GestionUsuarios.RecuperarClave(nombre);

            if (claveEncontrada != "No encontrado")
            {
               
                lblResultado.Text = "Su clave es: " + claveEncontrada;
                lblResultado.ForeColor = Color.DarkGreen;
            }
            else
            {
                MessageBox.Show("El usuario ingresado no existe en el sistema.");
                lblResultado.Text = "";
            }
        }
    }
}
