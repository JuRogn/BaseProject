using System;
using Infrastructure.Models;
using Module.Catalog.Models;
using Module.Core.Models;

namespace Module.ProductComparison.Models
{
    public class ComparingProduct : EntityBase
    {
        public DateTimeOffset CreatedOn { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }

        public long ProductId { get; set; }

        public Product Product { get; set; }
    }
}
