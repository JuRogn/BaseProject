using MediatR;
using Module.Core.Events;
using Module.Core.Extensions;
using Module.ProductComparison.Services;

namespace Module.ProductComparison.Events
{
    public class UserSignedInHandler : INotificationHandler<UserSignedIn>
    {
        private readonly IWorkContext _workContext;
        private readonly IComparingProductService _comparingService;

        public UserSignedInHandler(IWorkContext workContext, IComparingProductService comparingService)
        {
            _workContext = workContext;
            _comparingService = comparingService;
        }

        public void Handle(UserSignedIn user)
        {
            var guestUser = _workContext.GetCurrentUser().Result;
            _comparingService.MigrateComparingProduct(guestUser.Id, user.UserId);
        }
    }
}
