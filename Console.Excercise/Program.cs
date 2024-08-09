using System;
using SendingMail;
using FileReadAndWrite;
using System.IO;
using JsonExercise;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Console.Excercise
{
    class Projects
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            IConfiguration configuration;
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("AppSetting.json")
                .Build();

            serviceCollection.AddSingleton<IConfiguration>(configuration);
            Mailsending data = new Mailsending(configuration);
            data.LogException();
            //ReadAndWrite data = new ReadAndWrite();
            // data.File();
            //Program data = new Program();
            //data.Source();

        }
    }
}
