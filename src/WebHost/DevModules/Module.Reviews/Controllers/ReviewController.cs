using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using Module.Core.Extensions;
using Module.Reviews.Models;
using Module.Reviews.ViewModels;

namespace Module.Reviews.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IRepository<Review> _reviewRepository;
        private readonly IWorkContext _workContext;

        public ReviewController(IRepository<Review> reviewRepository, IWorkContext workContext)
        {
            _reviewRepository = reviewRepository;
            _workContext = workContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(ReviewForm model)
        {
            if (ModelState.IsValid)
            {
                var user = await _workContext.GetCurrentUser();
                var review = new Review
                {
                    Rating = model.Rating,
                    Title = model.Title,
                    Comment = model.Comment,
                    ReviewerName = model.ReviewerName,
                    EntityId = model.EntityId,
                    EntityTypeId = model.EntityTypeId,
                    UserId = user.Id,
                };

                _reviewRepository.Add(review);
                _reviewRepository.SaveChange();

                return PartialView("_ReviewFormSuccess", model);
            }
            return PartialView("_ReviewForm", model);
        }
    }
}