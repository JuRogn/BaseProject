﻿using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Module.Core.Events;

namespace Module.Core.Extensions
{
    public class SimplSignInManager<TUser> : SignInManager<TUser> where TUser : class
    {
        private readonly IMediator _mediator;

        public SimplSignInManager(UserManager<TUser> userManager,
            IHttpContextAccessor contextAccessor,
            IUserClaimsPrincipalFactory<TUser> claimsFactory,
            IOptions<IdentityOptions> optionsAccessor,
            ILogger<SignInManager<TUser>> logger,
            IMediator mediator)
            : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger)
        {
            _mediator = mediator;
        }

        public override async Task SignInAsync(TUser user, bool isPersistent, string authenticationMethod = null)
        {
            var userId = await UserManager.GetUserIdAsync(user);
            _mediator.Publish(new UserSignedIn {UserId = long.Parse(userId)});
            await base.SignInAsync(user, isPersistent, authenticationMethod);
        }
    }
}