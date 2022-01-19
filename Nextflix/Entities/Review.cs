using System;
namespace Nextflix.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string UserReview { get; set; }
        public int Points { get; set; }
         public int UserID { get; set; }
         public int MovieID{get;set;}
    }
}
