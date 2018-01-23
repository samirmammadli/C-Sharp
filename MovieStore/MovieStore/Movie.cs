using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore
{
    public static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }
    }

    class Movie
    {
        [Browsable(false)]
        Image MovieImage { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Type { get; set; }
        public string Runtime { get; set; }
        public string Year { get; set; }
        public bool Viewed { get; set; }

        public Movie(string title, string genre, string type, string runtime, string year, bool viewed, Image image = null)
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
        public Dictionary<int, Movie> Movies { get; private set; }

        public void AddMovie(Movie movie)
        {
            if (movie == null) throw new ArgumentNullException();
            Movies.Add(++IdCounter, movie);
            MovieCollectionChanged?.Invoke();
        }

        public void DeleteMovie(int id)
        {
            if (!Movies.ContainsKey(id)) throw new ArgumentException("Wrong Movie ID!");
            Movies.Remove(id);
            MovieCollectionChanged?.Invoke();
        }

        public void EditMovie(int id, Movie movie)
        {
            if (!Movies.ContainsKey(id)) throw new ArgumentException("Wrong Movie ID!");
            Movies[id] = movie;
            MovieCollectionChanged?.Invoke();
        }

    }
}
