using Infrastructure.Models;
using Module.Core.Models;

namespace Module.Catalog.Models
{
    public class ProductMedia : EntityBase
    {
        public long ProductId { get; set; }

        public virtual Product Product { get; set; }

        public long MediaId { get; set; }

        public virtual Media Media { get; set; }

        public int DisplayOrder { get; set; }
    }
}
