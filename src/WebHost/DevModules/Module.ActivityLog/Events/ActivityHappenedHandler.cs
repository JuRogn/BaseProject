using MediatR;
using Infrastructure.Data;
using Module.ActivityLog.Models;
using Module.Core.Events;

namespace Module.ActivityLog.Events
{
    public class ActivityHappenedHandler : INotificationHandler<ActivityHappened>
    {
        private readonly IRepository<Activity> _activityRepository;

        public ActivityHappenedHandler(IRepository<Activity> activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public void Handle(ActivityHappened notification)
        {
            var activity = new Activity
            {
                ActivityTypeId = notification.ActivityTypeId,
                EntityId = notification.EntityId,
                EntityTypeId = notification.EntityTypeId,
                CreatedOn = notification.TimeHappened
            };

            _activityRepository.Add(activity);
        }
    }
}
