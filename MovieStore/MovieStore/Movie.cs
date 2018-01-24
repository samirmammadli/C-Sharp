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

namespace MovieStore
{
    public static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, 0, comp) == 0;
        }
    }


    class MovieDataDownloader
    {
        Uri Link { get; set; }
        JObject Data { get; set; }

        public MovieDataDownloader(string link)
        {
            Link = new Uri(link);
        }

        public string[] GetData()
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
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

        public Image GetImage(string id)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    var data = webClient.DownloadString(Link);
                    dynamic obj = JObject.Parse(data);
                    if (obj.Response == "False")
                        throw new ArgumentException(obj.Error);
                    Link = new Uri(obj.Poster);
                    webClient.DownloadFile(obj.Poster, $@"\Posters\{id}.jpg");
                    return new Bitmap($@"\Posters\{id}.jpg");
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
            //Movies.Last().MovieImage = poster;
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
