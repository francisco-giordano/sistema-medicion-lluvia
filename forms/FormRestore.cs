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
    public partial class FormRestore : Form
    {
        public FormRestore()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            // 1. Preparamos la ventanita para buscar el archivo
            OpenFileDialog buscador = new OpenFileDialog();

            // Le decimos que solo le muestre archivos Excel/CSV para que no elija una foto por error
            buscador.Filter = "Archivos CSV (*.csv)|*.csv";
            buscador.Title = "Seleccione el archivo de Backup para restaurar";

            // 2. Abrimos la ventanita. Si el usuario elige un archivo y le da a "Abrir"...
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                // 3. ¡SIEMPRE PONER UNA CONFIRMACIÓN! Es una acción destructiva.
                DialogResult respuesta = MessageBox.Show(
                    "¿Estás seguro de que querés restaurar la base de datos?\nSe borrarán los usuarios actuales y se reemplazarán por los de la copia elegida.",
                    "Advertencia Crítica",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    // 4. Capturamos la ruta del archivo que eligió (ej: "C:\Backups\backup_usuario_20260707.csv")
                    string rutaElegida = buscador.FileName;

                    // 5. Llamamos a tu clase Restore
                    bool exito = Proyeto_Medicios_de_LLuvia.seguridad.Restore.RestaurarBaseDeDatos(rutaElegida);

                    if (exito)
                    {
                        MessageBox.Show("¡Sistema restaurado con éxito! La aplicación se cerrará para aplicar los cambios.", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Forzamos el cierre de la app para asegurar que la próxima vez que abran, lean el archivo viejo
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Surgió un error al restaurar. Revisá la bitácora para más detalles.", "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
