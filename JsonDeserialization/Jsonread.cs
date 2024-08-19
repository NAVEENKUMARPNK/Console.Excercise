using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace JsonDeserialization
{
    public class Jsonread

    {
        public void Program()
        {
            string FilePath = "C:\\Users\\user\\Downloads\\WeatherForecast-Result.json";
            string Json = File.ReadAllText(FilePath);
            List<WeatherForecast> Result = JsonConvert.DeserializeObject<List<WeatherForecast>>(Json);
            foreach(var source in Result)
            {
                Console.WriteLine($"date:{source.date },summary:{source.summary},temperaturec:{source.temperatureC},,temperatureF:{source.temperatureF}");
            }
        }

    }
}
