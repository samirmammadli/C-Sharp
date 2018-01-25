using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;

namespace MovieStore
{
    public static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, 0, comp) == 0;
        }
    }

    public static class UriExtensions
    {
        /// <summary>
        /// Adds the specified parameter to the Query String.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="paramName">Name of the parameter to add.</param>
        /// <param name="paramValue">Value for the parameter to add.</param>
        /// <returns>Url with added parameter.</returns>
        public static Uri AddParameter(this Uri url, string paramName, string paramValue)
        {
            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query[paramName] = paramValue;
            uriBuilder.Query = query.ToString();

            return uriBuilder.Uri;
        }
    }


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
                    string[] Data = { obj.Title, obj.Genre, obj.Type, obj.Runtime, obj.Year };
                    return Data;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        static public Image GetImage(string id, string title)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    Link = Link.AddParameter("t", title);
                    var data = webClient.DownloadString(Link);
                    Console.WriteLine(Link);
                    dynamic obj = JObject.Parse(data);
                    if (obj.Response == "False")
                        throw new ArgumentException(obj.Error);
                    webClient.DownloadFile((string)obj.Poster, $@"{Environment.CurrentDirectory}\Posters\{id}.jpg");
                    return new Bitmap($@"Posters\{id}.jpg");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }

    class Movie
    {
        [Browsable(false)]
        public Image MovieImage { get; set; }
        [Browsable(false)]
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Type { get; set; }
        public string Runtime { get; set; }
        public int Year { get; set; }
        public bool Viewed { get; set; }

        public Movie(string title, string genre, string type, string runtime, int year, bool viewed, Image image = null)
        {
            Title = title;
            Genre = genre;
            Type = type;
            Runtime = runtime;
            Year = year;
            MovieImage = image;
            Viewed = viewed;
        }
    }

    class MovieStore
    {
        public delegate void MovieCollectionStateHandler();
        public event MovieCollectionStateHandler MovieCollectionChanged;
        private static int IdCounter = 0;
        public List<Movie> Movies { get; private set; }

        public MovieStore()
        {
            Movies = new List<Movie>();
        }

        public void AddMovie(Movie movie, Image poster = null)
        {
            if (movie == null) throw new ArgumentNullException();
            Movies.Add(movie);
            Movies.Last().MovieID = ++IdCounter;
            if (poster == null)
                Movies.Last().MovieImage = new Bitmap($@"{Environment.CurrentDirectory}\Posters\no_poster.jpg");

            MovieCollectionChanged?.Invoke();
        }

        public void DeleteMovie(int id)
        {
            try
            {
                Movies.RemoveAt(Movies.FindIndex(x => x.MovieID == id));
                MovieCollectionChanged?.Invoke();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditMovie(int id, Movie movie)
        {
            if (movie == null) throw new ArgumentNullException();
            try
            {
                int index = Movies.FindIndex(x => x.MovieID == id);
                Movies.RemoveAt(index);
                MovieCollectionChanged?.Invoke();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
