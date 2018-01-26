using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MovieStore
{
    public enum OperationType
    {
        Add,
        Edit
    }


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
                Movies.Last().MovieImagePath = $@"{Environment.CurrentDirectory}\Posters\no_poster.jpg";
            else
            {
                poster.Save($@"{Environment.CurrentDirectory}\Posters\{Movies.Last().MovieID}.jpg");
                Movies.Last().MovieImagePath = $@"{Environment.CurrentDirectory}\Posters\{Movies.Last().MovieID}.jpg";
            }

            MovieCollectionChanged?.Invoke();
        }

        public void DeleteMovie(int id)
        {
            try
            {
                Movies.RemoveAt(Movies.FindIndex(x => x.MovieID == id));
                if (File.Exists($@"{Environment.CurrentDirectory}\Posters\{id}.jpg"))
                    File.Delete($@"{Environment.CurrentDirectory}\Posters\{id}.jpg");
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
                    Movies[index].MovieImagePath = $@"{Environment.CurrentDirectory}\Posters\no_poster.jpg";
                else
                {
                    File.Delete($@"{Environment.CurrentDirectory}\Posters\{id}.jpg");
                    poster.Save($@"{Environment.CurrentDirectory}\Posters\{id}.jpg");
                    Movies[index].MovieImagePath = $@"{Environment.CurrentDirectory}\Posters\{id}.jpg";
                    poster.Dispose();
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
