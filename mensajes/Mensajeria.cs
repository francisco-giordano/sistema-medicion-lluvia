using Proyeto_Medicios_de_LLuvia.seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Wapi2.SDK;

namespace Proyeto_Medicios_de_LLuvia.mensajes
{
    public class Mensajeria
    {
        public static void EnviarSMS(string numeroDestino, string mensaje)
        {
            if (numeroDestino == "" || mensaje == "") return;

            // Estos datos te los da Twilio al crearte la cuenta
            string accountSid = "TU_ACCOUNT_SID";
            string authToken = "TU_AUTH_TOKEN";

            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(new PhoneNumber(numeroDestino));
            messageOptions.From = new PhoneNumber("+5491140411774"); // Tu número de Twilio
            messageOptions.Body = mensaje;

            var msg = MessageResource.Create(messageOptions);
            Bitacora.Registrar($"[SISTEMA] SMS enviado al número {numeroDestino}");
        }

       

        public static void EnviarWhatsApp(string numeroDestino, string mensaje)
        {
            if (string.IsNullOrWhiteSpace(numeroDestino) || string.IsNullOrWhiteSpace(mensaje))
                return;

            try
            {
                // 1. Inicializás el cliente con la clave que te da la página de Wapi
                WhatsAppClient cliente = new WhatsAppClient("9fb2fbed-f806-4564-8c6a-da3e2d84b81d", "MESSI");

                // 2. Mandás el mensaje directo (asegurate de que el número tenga el +549...)
                cliente.SendMessageAsync("NOMBRE_DE_SESION", numeroDestino, mensaje).Wait();

                Bitacora.Registrar($"[SISTEMA] WhatsApp (Wapi2) enviado con éxito a {numeroDestino}");
            }
            catch (Exception ex)
            {
                // Si falla (ej: sin internet o API key vencida), no se cuelga el programa
                Bitacora.Registrar($"[ERROR] Falló envío de WhatsApp por Wapi2 a {numeroDestino}. Detalle: {ex.Message}");
            }
        }

    }

}












