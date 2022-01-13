using Nextflix.Controllers;
using Nextflix.Entities;
using Nextflix.Repositories;
using System.Collections.Generic;
using System.Linq;




namespace Nextflix.Repositories

{
    public class ReviewRepository : IReviewRepository
   
    {
        private readonly List<Review> _reviewCollection = new List<Review>()  { 
        { 
            new Review() { id = 1, review = "It was nice", points = 5, userID  = 1,  movieID = 1} }};

        public IEnumerable<Review> GetReviews()
        {
            return _reviewCollection;
        }
        public void CreateReview(Review review)
        {
            _reviewCollection.Add(review);
       
        }

        public void DeleteReview(int id)
        {
            var reviewToDelete = _reviewCollection.Where(r => r.id == id).SingleOrDefault();
            _reviewCollection.Remove(reviewToDelete);
        }

        

        public Review GetReview(int id)
        {
            
             return _reviewCollection.Where(d => d.id == id).SingleOrDefault();
        }

        

        

       
    }
}