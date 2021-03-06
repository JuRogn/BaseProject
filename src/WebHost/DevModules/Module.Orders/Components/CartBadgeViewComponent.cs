﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Module.Core.Extensions;
using Module.Orders.Services;

namespace Module.Orders.Components
{
    public class CartBadgeViewComponent : ViewComponent
    {
        private ICartService _cartService;
        private IWorkContext _workContext;

        public CartBadgeViewComponent(ICartService cartService, IWorkContext workContext)
        {
            _cartService = cartService;
            _workContext = workContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentUser = await _workContext.GetCurrentUser();
            var cartItemCount = _cartService.GetCartItems(currentUser.Id).Count;
            return View("/Modules/Module.Orders/Views/Components/CartBadge.cshtml", cartItemCount);
        }
    }
}
