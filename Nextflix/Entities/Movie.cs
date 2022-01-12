using System;
using System.Collections.Generic;

namespace Nextflix.Entities
{
    public class Movie
    {
        public int id { get; set; }
        public DateTime releaseDate { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int directorId { get; set; }
        public Category category { get; set; }
    }
}
