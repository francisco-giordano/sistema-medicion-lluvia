using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyeto_Medicios_de_LLuvia
{
    public partial class FormMail : Form
    {
        public FormMail()
        {
            InitializeComponent();
        }

        private void FormMail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreMail.Text.Trim();
            string apellido = txtApellidoMail.Text.Trim();
            string descripcion = txtDescripMail.Text.Trim();

            // Primero validar campos vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, completá todos los campos antes de enviar.");
                return;
            }

            // Después validar el DNI
            if (!int.TryParse(txtDniMail.Text.Trim(), out int dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.");
                return;
            }

            EnviarMail(nombre, apellido, dni, descripcion);
        }
        private void EnviarMail(string nombre, string apellido, int dni, string descripcion)
        {
            try
            {
                MailMessage mensaje = new MailMessage();

                mensaje.From = new MailAddress("emipungitore@gmail.com");
                mensaje.To.Add("emipungitore@gmail.com");
                mensaje.Subject = "Solicitud de registro de nuevo usuario";
                mensaje.Body = $"Se ha recibido una nueva solicitud de registro.\n\n" +
                               $"Datos del solicitante:\n" +
                               $"  Nombre:      {nombre}\n" +
                               $"  Apellido:    {apellido}\n" +
                               $"  DNI:         {dni}\n\n" +
                               $"  Descripción: {descripcion}\n\n" +
                               $"Por favor, responda este correo con las credenciales asignadas al usuario.";

                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new NetworkCredential(
                    "emipungitore@gmail.com",
                    "tdhh wlxz uzxo spzn"  
                );
                cliente.EnableSsl = true;
                cliente.Send(mensaje);

                MessageBox.Show("La solicitud de registro fue enviada con éxito.\n" +
                                "El administrador te asignará tus credenciales a la brevedad.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Surgió un error al enviar el correo:\n" + ex.Message);
            }
        }
    }
}

