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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            GestionRoles.IniciarRoles();
        }

        private void gestorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 gestor = new Form1();

            gestor.MdiParent = this;
            gestor.Show();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLog login = new FormLog();
            login.MdiParent = this;
            login.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogOut logout = new FormLogOut();
            logout.MdiParent = this;
            logout.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormRegistro Registro = new FormRegistro();
           Registro.MdiParent = this;
            Registro.Show();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {







        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
