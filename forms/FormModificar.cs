using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyeto_Medicios_de_LLuvia.forms
{
    public partial class FormModificar : Form
    {
        // 1. Declaramos las dos variables maestras
        private UsuarioFinal usuarioAEditar;
        private UsuarioFinal copiaDeSeguridad;
        public FormModificar(UsuarioFinal usuarioSeleccionado)
        {
            InitializeComponent();
            usuarioAEditar = usuarioSeleccionado;

            // ¡ACÁ SUCEDE LA MAGIA DEL ICLONEABLE! 
            // Hacemos un clon idéntico pero desconectado de la memoria original
            copiaDeSeguridad = (UsuarioFinal)usuarioAEditar.Clone();
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
           // Apenas carga la pantalla, llenamos las cajas con los datos actuales
            txtModificarUser.Text = usuarioAEditar.NombreUsuario;

            // Bloqueamos la caja del nombre de usuario para que no puedan cambiarlo
            // (El nombre de usuario suele ser intocable, como el DNI)
            txtModificarUser.Enabled = false;

            txtModificarPass.Text = usuarioAEditar.ClaveUsuario;
            txtModificarPais.Text = usuarioAEditar.Pais;

            // Acá podrías cargar el ComboBox de roles como hacías en el FormRegistro...
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            // Validamos que no dejen cosas vacías(usando "" como venís haciendo)
            if (txtModificarPass.Text == "" || txtModificarPais.Text == "")
            {
                MessageBox.Show("Por favor, completá todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aplicamos los cambios al objeto original en memoria
            usuarioAEditar.ClaveUsuario = txtModificarPass.Text; // Idealmente encriptada después
            usuarioAEditar.Pais = txtModificarPais.Text;

            // Acá aplicarías el rol seleccionado del combo a usuarioAEditar.MiFamilia

            MessageBox.Show("¡Usuario actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // ¡ACÁ USAMOS EL CLON COMO SALVAVIDAS!
            // Si el admin hizo un lío y tocó cancelar, pisamos el objeto original con los datos intactos del clon
            usuarioAEditar.NombreUsuario = copiaDeSeguridad.NombreUsuario;
            usuarioAEditar.ClaveUsuario = copiaDeSeguridad.ClaveUsuario;
            usuarioAEditar.Pais = copiaDeSeguridad.Pais;
            usuarioAEditar.MiFamilia = copiaDeSeguridad.MiFamilia;

            MessageBox.Show("Se canceló la edición. Los datos volvieron a su estado original.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
