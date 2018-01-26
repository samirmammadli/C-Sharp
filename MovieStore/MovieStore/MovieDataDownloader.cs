using System;
using System.Drawing;
using System.Drawing.Imaging;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Text;

namespace MovieStore
{
    static class MovieDataDownloader
    {
        private static Uri Link = new Uri(@"http://www.omdbapi.com/?apikey=e55850b5");
        private static JObject Data = null;


        public static string[] GetData(string title)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    
                    Link = Link.AddParameter("t", title);
                    var data = Encoding.UTF8.GetString(webClient.DownloadData(Link));
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

        public static Image GetImage(string link)
        {
            Bitmap img = null;
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    MemoryStream stream = new MemoryStream(webClient.DownloadData(link));
                    img = new Bitmap(stream);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return img;
        }
    }
}
