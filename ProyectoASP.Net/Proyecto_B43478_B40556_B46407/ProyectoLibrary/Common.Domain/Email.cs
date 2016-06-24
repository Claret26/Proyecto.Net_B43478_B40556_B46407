using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class Email
    {

        private MailMessage m;
        private SmtpClient smtp;

        public Email()
        {
            this.m = new MailMessage();
            this.smtp = new SmtpClient();
        }

        public void enviarMensaje(String from, String password, String to, String mensaje)
        {

            try
            {
                m.From = new MailAddress(from);
                m.To.Add(new MailAddress(to));
                m.Subject = "Empresa Bolsa de Empleo";
                m.Body = mensaje;

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(from, password);
                smtp.EnableSsl = true;
                smtp.Send(m);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
