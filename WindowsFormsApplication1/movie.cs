using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class movie
    {
        public string id,title,director,year,genres,rating,poster,mov;
        public movie(string id, string title, string director, string year,string genres, string rating, string poster,string movie)
        {
            this.id = id;
            this.title = title;
            this.director = director;
            this.year = year;
            this.genres = genres;
            this.rating = rating;
            this.poster = poster;
            this.mov = movie;
        }

    }
}
