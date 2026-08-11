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
    public partial class FormLogOut : Form
    {
        public FormLogOut()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            
            GestionUsuarios.LogOut();

            MessageBox.Show("Sesión cerrada correctamente.", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormLog login = new FormLog();
            login.Show();
            this.Close();
        }

        private void FormLogOut_Load(object sender, EventArgs e)
        {


        }
    }
}
