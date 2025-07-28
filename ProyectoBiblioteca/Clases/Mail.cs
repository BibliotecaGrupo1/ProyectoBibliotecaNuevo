using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Net.Mail;
using System.Net.Mime;
using ContentDisposition = MimeKit.ContentDisposition;

namespace ProyectoBiblioteca.Clases
{
    public static class Mail
    {
        public static void EnviarCorreoBienvenida(string correoDestino, string nombreUsuario)
        {
            var mensaje = new MimeMessage();
            mensaje.From.Add(new MailboxAddress("Biblioteca Virtual", "gengarbibliotecauwu@gmail.com"));
            mensaje.To.Add(new MailboxAddress(nombreUsuario, correoDestino));
            mensaje.Subject = "¡Bienvenido a la Biblioteca Virtual!";

            // Cuerpo del mensaje
            var cuerpo = new TextPart("plain")
            {
                Text = $"Hola {nombreUsuario},\n\n¡Bienvenido a la Biblioteca Virtual!\nTu registro ha sido exitoso.\n\nSaludos,\nEquipo Biblioteca"
            };

            // Ruta absoluta del PDF a adjuntar
            string rutaPdf = @"C:\Users\Frank\source\repos\ProyectoBibliotecaNuevo/Bienvenida.pdf";

            var adjunto = new MimePart("application", "pdf")
            {
                Content = new MimeContent(System.IO.File.OpenRead(rutaPdf)),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = "Bienvenida.pdf"
            };

            // Crear el cuerpo del mensaje con el adjunto
            var multipart = new Multipart("mixed");
            multipart.Add(cuerpo);
            multipart.Add(adjunto);

            mensaje.Body = multipart;

            using (var cliente = new MailKit.Net.Smtp.SmtpClient())
            {
                cliente.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                cliente.Authenticate("gengarbibliotecauwu@gmail.com", "mfui hpzc jmxb obja");
                cliente.Send(mensaje);
                cliente.Disconnect(true);
            }
        }


        public static void EnviarLogroCorreo(string correoDestino, string nombreUsuario, string logro)
        {
            var mensaje = new MimeMessage();
            mensaje.From.Add(new MailboxAddress("Biblioteca Virtual", "gengarbibliotecauwu@gmail.com"));
            mensaje.To.Add(new MailboxAddress(nombreUsuario, correoDestino));
            mensaje.Subject = "¡Felicidades por tu logro en la Biblioteca Virtual!";

            var cuerpo = new TextPart("plain")
            {
                Text = $"Hola {nombreUsuario},\n\n¡Felicidades! Has obtenido el logro: {logro}.\n\nSigue disfrutando de nuestra biblioteca.\n\nSaludos,\nEquipo Biblioteca"
            };

            // Ruta absoluta del PDF a adjuntar
            string rutaPdf = @"C:\Users\Frank\source\repos\ProyectoBibliotecaNuevo\PrimerLogro.pdf";

            var adjunto = new MimePart("application", "pdf")
            {
                Content = new MimeContent(System.IO.File.OpenRead(rutaPdf)),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = "PrimerLogro.pdf"
            };

            var multipart = new Multipart("mixed");
            multipart.Add(cuerpo);
            multipart.Add(adjunto);

            mensaje.Body = multipart;

            using (var cliente = new MailKit.Net.Smtp.SmtpClient())
            {
                cliente.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                cliente.Authenticate("gengarbibliotecauwu@gmail.com", "mfui hpzc jmxb obja");
                cliente.Send(mensaje);
                cliente.Disconnect(true);
            }
        }
    }
}