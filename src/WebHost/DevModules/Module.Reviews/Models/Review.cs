using System;
using Infrastructure.Models;
using Module.Core.Models;

namespace Module.Reviews.Models
{
    public class Review : EntityBase
    {
        public Review()
        {
            Status = ReviewStatus.Pending;
            CreatedOn = DateTimeOffset.Now;
        }

        public long UserId { get; set; }

        public User User { get; set; }

        public string Title { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

        public string ReviewerName { get; set; }

        public ReviewStatus Status { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public long EntityTypeId { get; set; }

        public long EntityId { get; set; }
    }
}
