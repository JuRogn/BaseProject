using Module.Core.Models;

namespace Module.Orders.Services
{
    public interface IOrderService
    {
        void CreateOrder(User user, Address billingAddress, Address shippingAddress);
    }
}
