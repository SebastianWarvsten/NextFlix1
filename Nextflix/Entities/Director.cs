using System;
using System.Collections.Generic;

namespace Nextflix.Entities
{
    public class Director
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Movie> Movie { get; set; } = new List<Movie>();
    }
}
