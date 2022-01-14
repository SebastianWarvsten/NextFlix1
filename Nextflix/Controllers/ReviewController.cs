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
    public class ReviewRController : ControllerBase
    {
        private readonly  IReviewRepository _reviewRepository;

        public ReviewRController(IReviewRepository reviewRepository) { _reviewRepository = reviewRepository; }

        [HttpGet]
        public IEnumerable<Review> GetReviews(int id) { return _reviewRepository.GetReviews(id); }

        [HttpGet("{id}")]
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
                _reviewRepository.DeleteReview(reviewItem.id);
                return Ok("Review successfuly deleted!");
            }
            else
            {
                return NotFound();
            }
        }



        [HttpPost]

         public ActionResult<Review> CreateReview(Review rev)
        {
            _reviewRepository.CreateReview(rev);
            return CreatedAtAction(nameof(GetReview), new {id = rev.id, review = rev.review, points = rev.points, userID = rev.userID, movieID = rev.movieID}, rev);

        }
    }
}