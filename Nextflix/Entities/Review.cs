﻿using System;
namespace Nextflix.Entities
{
    public class Review
    {
        public int id { get; set; }
        public string review { get; set; }
        public int points { get; set; }
         public int userID { get; set; }
         public int movieID{get;set;}
    }
}
