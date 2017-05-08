using System.Collections.Generic;
using Module.Orders.Models;

namespace Module.Orders.Services
{
    public interface ICartService
    {
        CartItem AddToCart(long userId, long productId, string variationName, int quantity);

        IList<CartItem> GetCartItems(long userId);

        void MigrateCart(long fromUserId, long toUserId);
    }
}
