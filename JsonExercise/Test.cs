using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExercise
{
    public class Test
    {
        private readonly IConfiguration configuration;
        public Test(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void TestMethod()
        {
            var datafromJsonFile = configuration.GetSection("Name").Value;
            Console.WriteLine(datafromJsonFile);
        }
    }
}
