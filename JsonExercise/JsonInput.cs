//using System;
//using System.IO;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//namespace JsonExercise
//{
//    public class Program
//    {
//        public void Source()
//        {
//            var serviceCollection = new ServiceCollection();
//            IConfiguration configuration;
//            configuration = new ConfigurationBuilder()
//                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
//                .AddJsonFile("AppSetting.json")
//                .Build();
            
//            serviceCollection.AddSingleton<IConfiguration>( configuration);
//            serviceCollection.AddSingleton<Test>();

//            var serviceProvider = serviceCollection.BuildServiceProvider();
//            var testInstance = serviceProvider.GetService<Test>();
//            testInstance.TestMethod();


//        }
//    }
//}
