using Infrastructure.Models;
using Module.Catalog.Models;

namespace Module.Orders.Models
{
    public class OrderItem : EntityBase
    {
        public virtual Order Order { get; set; }

        public long ProductId { get; set; }

        public virtual Product Product { get; set; }

        public decimal ProductPrice { get; set; }

        public int Quantity { get; set; }
    }
}
