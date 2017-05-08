using System.Linq;
using Infrastructure.Data;
using Module.Reviews.Models;

namespace Module.Reviews.Data
{
    public interface IReviewRepository : IRepository<Review>
    {
        IQueryable<ReviewListItemDto> List();
    }
}