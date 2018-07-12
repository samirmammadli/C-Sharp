using AppDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MoviePlugin
{

    public class MovieInfo
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Error { get; set; }

        public override string ToString()
        {
            if (Error != null) return Error;
            return $"Title:  {Title}\n" +
                    $"Year:  { Year }\n" +
                    $"Rated:  { Rated }\n" +
                    $"Released:  {Released }\n" +
                    $"Runtime:  { Runtime }\n" +
                    $"Genre:  { Genre }\n" +
                    $"Director:  { Director }\n" +
                    $"Writer:  { Writer }\n" +
                    $"Actors:  { Actors }\n" +
                    $"Plot:  {Plot }\n" +
                    $"Language:  { Language }\n" +
                    $"Country:  { Country }\n" +
                    $"Awards:  { Awards }";

        }
    }

    public class Movie : IPlugin
    {
        public string Request(string input)
        {
            try
            {
                using (var client = new WebClient { Encoding = Encoding.UTF8 })
                {
                    var data = client.DownloadString($@"http://www.omdbapi.com/?apikey=e55850b5&t={input}");
                    dynamic obj = JsonConvert.DeserializeObject<MovieInfo>(data);
                    return obj.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public override string ToString()
        {
            return "Movie Plugin";
        }
    }
}
