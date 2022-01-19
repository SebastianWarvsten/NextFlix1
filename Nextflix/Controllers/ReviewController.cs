using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nextflix.Repositories;
using Nextflix.Controllers;
using Nextflix.Entities;
using System.Collections.Generic;

namespace Nextflix.Controllers
{
    [Route("api/Movies/{movieId}/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly  IReviewRepository _reviewRepository;

        public ReviewController(IReviewRepository reviewRepository) { _reviewRepository = reviewRepository; }

        [HttpGet]
        
       
        public ActionResult<IEnumerable<Review>> GetReviewsForMovie(int movieId)
        {
            System.Console.WriteLine($"--> Get reviews for movie: {movieId}");
            return Ok(_reviewRepository.GetReviews(movieId));

        }


        [HttpGet("{id}", Name = "GetReview")]
        public ActionResult<Movie> GetReview(int id) 
        {
            var review = _reviewRepository.GetReview(id);

            if (review == null)
            {
                return NotFound();
            }
            return Ok(review);
        }

        
        [HttpDelete("{id}")]
        

            public ActionResult DeleteReview(int id)
        {
            var reviewItem = _reviewRepository.GetReview(id);
            if (reviewItem != null)
            {
                _reviewRepository.DeleteReview(reviewItem.Id);
                return Ok("Review successfuly deleted!");
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPost]

        public ActionResult<Review> CreateReview(int movieId, Review rev, int userID)
        {
            System.Console.WriteLine("---> Creating review");
            _reviewRepository.CreateReview(movieId, rev,  userID);
            return Ok();

        }
    }
}