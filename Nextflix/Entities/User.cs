using System;
using System.Collections.Generic;

namespace Nextflix.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
