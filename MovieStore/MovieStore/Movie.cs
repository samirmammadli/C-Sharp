using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore
{

    public class Movie
    {
        public Image MovieImage { get; set; }
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
}
