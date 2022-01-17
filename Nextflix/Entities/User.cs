using System;
using System.Collections.Generic;

namespace Nextflix.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        //public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
