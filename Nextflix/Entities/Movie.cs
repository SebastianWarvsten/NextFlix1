using System;
using System.Collections.Generic;

namespace Nextflix.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int DirectorID { get; set; }
        public Category Category { get; set; }
        public Director Director { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
