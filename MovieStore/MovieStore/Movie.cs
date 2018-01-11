using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore
{
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Type { get; set; }
        public int Runtime { get; set; }
        public int Year { get; set; }

        public Movie(string title, string genre, string type, int runtime, int year)
        {
            Title = title;
            Genre = genre;
            Type = type;
            Runtime = runtime;
            Year = year;
        }
    }
}
