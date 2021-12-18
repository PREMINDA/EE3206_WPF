using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using MimeKit;

namespace EE3206_WPF.Windows
{
    class EmailService
    {
        public void sendmessage(string email,string subject,string messageinf)
        
        {

            MailMessage message = new MailMessage();
            message.From = new MailAddress(email);
            message.To.Add(email);
            message.Subject = subject;

            message.Body = messageinf;

            using (var client = new SmtpClient("smtp.friends.com"))
            {
                client.EnableSsl = true;
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new NetworkCredential("Prebandrazer@gmail.com", "P#0775758922*M");
                
                client.Send(message);

            }

        }

    }
}
