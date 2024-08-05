using System;
using System.IO;

namespace FileReadAndWrite
{
    public class ReadAndWrite
    {
        
        public void File()

        {
            string data;
            StreamReader Reader = null;
            StreamWriter writer = null;
            try
            {

                Reader = new StreamReader("C:\\dog.txt");
               
                data = Reader.ReadLine();
                while (data != null)
                {
                    Console.WriteLine(data);
                    data = Reader.ReadLine();
                }
                Reader.Close();
                writer = new StreamWriter("C:\\replaced.txt");

                writer.WriteLine(@"hi i am naveenkumar i have completed my btech degree");
                

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                writer.Close();
            }
            
            
        }
    }
}
