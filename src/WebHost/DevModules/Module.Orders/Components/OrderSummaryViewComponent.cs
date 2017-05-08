using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Module.Core.Extensions;
using Module.Orders.Services;
using Module.Orders.ViewModels;

namespace Module.Orders.Components
{
    public class OrderSummaryViewComponent : ViewComponent
    {
        private readonly ICartService _cartService;
        private readonly IWorkContext _workContext;

        public OrderSummaryViewComponent(ICartService cartService, IWorkContext workContext)
        {
            _cartService = cartService;
            _workContext = workContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var curentUser = await _workContext.GetCurrentUser();

            var cartItems = _cartService.GetCartItems(curentUser.Id);
            var model = new CartViewModel
            {
                CartItems = cartItems.Select(x => new CartListItem
                {
                    Id = x.Id,
                    ProductName = x.Product.Name,
                    ProductPrice = x.Product.Price,
                    Quantity = x.Quantity,
                    VariationOptions = CartListItem.GetVariationOption(x.Product)
                }).ToList()
            };

            return View("/Modules/Module.Orders/Views/Components/OrderSummary.cshtml", model);
        }
    }
}
