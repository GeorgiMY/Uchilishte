using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesProject.Data.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Director { get; set; } = null!;
        public int Year { get; set; }
        public string Genre { get; set; } = null!;
    }
}
