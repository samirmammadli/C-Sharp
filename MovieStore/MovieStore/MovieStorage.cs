using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore
{
    public enum OperationType
    {
        Add,
        Edit
    }

    [Serializable]
    class MovieStorage
    {
        public delegate void MovieCollectionStateHandler();
        public event MovieCollectionStateHandler MovieCollectionChanged;
        private static int IdCounter = 0;
        public List<Movie> Movies { get; private set; }

        public MovieStorage()
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
            else
            {
                poster.Save($@"{Environment.CurrentDirectory}\Posters\{Movies.Last().MovieID}.jpg");
                Movies.Last().MovieImage = poster;
            }

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

        public void EditMovie(int id, Movie movie, Image poster = null)
        {
            if (movie == null) throw new ArgumentNullException();
            try
            {
                int index = Movies.FindIndex(x => x.MovieID == id);
                Movies[index] = movie;
                Movies[index].MovieID = id;
                if (poster == null)
                    Movies[index].MovieImage = new Bitmap($@"{Environment.CurrentDirectory}\Posters\no_poster.jpg");
                else
                {
                    poster.Save($@"{Environment.CurrentDirectory}\Posters\{Movies.Last().MovieID}.jpg");
                    Movies[index].MovieImage = poster;
                }
                MovieCollectionChanged?.Invoke();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
