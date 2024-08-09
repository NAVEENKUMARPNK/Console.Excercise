using System;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;




namespace SendingMail
{
    public class Mailsending
    {
       
            private readonly IConfiguration configuration;
        

        public Mailsending(IConfiguration configuration)
            {
               this. configuration = configuration;
            }

       
        public  void LogException()

        {
            
            string file = $"file_{DateTime.Now.ToString("yyyy-MM-dd")}.txt";
            try
            {
                send();
                using StreamWriter writer = new StreamWriter($"D:{file}.txt", false);
                {

                    writer.WriteLine($"successfully mail send { DateTime.Now.ToString("yyyy-MM-dd")}");
                    writer.Close();
                }

                
            }
            catch(Exception e)
            {
                using StreamWriter writer1 = new StreamWriter($"D:{file}.txt", false);
                {
                    writer1.WriteLine(e.StackTrace);
                    writer1.Close();
                }
               

            }

        }
        private void send()
        {

            SendEmail(GetUserName(), GetPassword());
            

        }

        

        private void SendEmail(string fromAddress, string password)
        {
            using SmtpClient email = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential( fromAddress, password)

            };
            string subject = "Course Enqurey";
            string body = $"Hello! My name is Naveen, and I have a question about [specific course/issue]. Can you help me this is the main mail sent @ {DateTime.UtcNow:F}";

            try
            {
                Console.WriteLine("sending email **********");
                email.Send(fromAddress, ToAddress(), subject, body);
                Console.WriteLine("email sent");

            }
           catch (SmtpException e)
            {
                throw;
            }
            

        }
       
       
        public  string GetUserName()
        {
            var datafromJsonFile = configuration.GetSection("FromAddress").Value;
             return datafromJsonFile;
        }
        public  string GetPassword()
        {

            var datafromJsonFile1 = configuration.GetSection("Password").Value;
            return datafromJsonFile1;
        }
        public  string ToAddress()
        {
            var datafromJsonFile1 = configuration.GetSection("ToAddress").Value;
            return datafromJsonFile1;
        }
        

    }
}
