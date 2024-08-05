using System;
using SendingMail;
using FileReadAndWrite;
using System.IO;

namespace Console.Excercise
{
    class Projects
    {
        static void Main(string[] args)
        {
            Mailsending data = new Mailsending();
             data.LogException();
            //ReadAndWrite data = new ReadAndWrite();
           // data.File();

        }
    }
}
