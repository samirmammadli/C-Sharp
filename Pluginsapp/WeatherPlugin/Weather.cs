using AppDll;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherPlugin
{
    public class Weather : IPlugin
    {
        public string Request(string input)
        {
            using (var client = new WebClient())
            {
                try
                {
                    var query = $@"http://api.openweathermap.org/data/2.5/weather?q={input}&units=metric&appid=bf39fad37848cac5e2f9d0106327cc98";
                    var answer = client.DownloadString(query);
                    dynamic output = JsonConvert.DeserializeObject(answer);
                    answer = $"City name: {output.name}\n" +
                        $"Country: {output.sys.country}\n" +
                        $"City id: {output.id}\n" +
                        $"Tempirature: {output.main.temp}\n";
                    return answer;
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
            }
        }

        public override string ToString()
        {
            return "Weather Plugin";
        }
    }
}
