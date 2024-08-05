using System;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.IO;

namespace SendingMail
{
    public class Mailsending
    {
        public  void LogException()
        {
            string file = $"file{DateTime.Now.ToString("yyyy-MM-dd")}";
            try
            {
                
                StreamWriter writer = new StreamWriter($"D:{file}.txt", false);

                send();

               writer.WriteLine($"successfully mail send { DateTime.Now.ToString("yyyy-MM-dd")}");

                writer.Close();
            }
            catch(Exception e)
            {
                 StreamWriter writer1 = new StreamWriter($"D:{file}.txt", false);
                writer1.WriteLine(e.StackTrace);
                writer1.Close();

            }

        }
        public void send()
        {
            
            
            SendEmail(fromAddress: GetUserName(), GetPassword());
            Console.ReadLine();
        }
        public static void SendEmail(string fromAddress, string password)
        {
            using SmtpClient email = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential(userName: fromAddress, password)

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
       
       
        public static string GetUserName()
        {
            return "naveenkumarpnk203@gmail.com";
        }
        public static string GetPassword()
        {
            return "uaogxgeztkoiabki";
        }
        public static string ToAddress()
        {
            return "naveenkumarpnk203@gmail.com";
        }
        

    }
}
