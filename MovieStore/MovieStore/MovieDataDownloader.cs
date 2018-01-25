using System;
using System.Drawing;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace MovieStore
{
    static class MovieDataDownloader
    {
        static private Uri Link = new Uri(@"http://www.omdbapi.com/?apikey=e55850b5");
        static private JObject Data = null;


        static public string[] GetData(string title)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    Link = Link.AddParameter("t", title);
                    var data = webClient.DownloadString(Link);
                    dynamic obj = JObject.Parse(data);
                    if (obj.Response == "False")
                        throw new ArgumentException(obj.Error);
                    string[] Data = { obj.Title, obj.Genre, obj.Type, obj.Runtime, obj.Year, obj.Poster };
                    return Data;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        static public Image GetImage(string link)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    ;
                    //webClient.DownloadFile(link, $@"{Environment.CurrentDirectory}\Posters\{id}.jpg");

                    //return new Bitmap($@"Posters\{id}.jpg");
                    MemoryStream stream = new MemoryStream(webClient.DownloadData(link));
                    return new Bitmap(stream);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
