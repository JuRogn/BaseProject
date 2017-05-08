using System;
using Infrastructure.Models;

namespace Module.ActivityLog.Models
{
    public class Activity : EntityBase
    {
        public long ActivityTypeId { get; set; }

        public ActivityType ActivityType { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public long EntityId { get; set; }

        public long EntityTypeId { get; set; }
    }
}
