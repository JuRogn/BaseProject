using System;
using Infrastructure.Models;
using Module.Catalog.Models;
using Module.Core.Models;

namespace Module.Orders.Models
{
    public class CartItem : EntityBase
    {
        public DateTimeOffset CreatedOn { get; set; }

        public long UserId { get; set; }

        public virtual User User { get; set; }

        public long ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
