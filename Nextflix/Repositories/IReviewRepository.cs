using Nextflix.Entities;
using System.Collections.Generic;

namespace Nextflix.Controllers
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetReviews();
        Review GetReview(int id);
       
        void CreateReview(Review review);
         void DeleteReview(int id);
    }
}