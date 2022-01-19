using Nextflix.Controllers;
using Nextflix.Entities;
using Nextflix.Data;
using Nextflix.Repositories;
using System.Collections.Generic;
using System.Linq;




namespace Nextflix.Repositories

{
    public class ReviewRepository : IReviewRepository

     
   
    {
        
        
        private readonly ApplicationDbContext _context;

        public ReviewRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Review> GetReviews(int id)
        
        {
            return _context.Review
          .Where(r => r.MovieID == id);
        }

        public void CreateReview(int movieId, Review review, int userID)
        {
            review.MovieID = movieId;
            review.UserID = userID;

            _context.Review.Add(review);
            _context.SaveChanges();
           
        }

       
        public void DeleteReview(int id)
        {
            var reviewToDelete = _context.Review.Where(m => m.Id == id).SingleOrDefault();
            _context.Review.Remove(reviewToDelete);
            _context.SaveChanges();
        }



        public Review GetReview(int id)
        {

            return _context.Review.Where(d => d.Id == id).SingleOrDefault();
        }

        

        

       
    }
}