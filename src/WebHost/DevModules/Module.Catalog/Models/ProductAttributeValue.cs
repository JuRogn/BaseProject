﻿using Infrastructure.Models;

namespace Module.Catalog.Models
{
    public class ProductAttributeValue : EntityBase
    {
        public long AttributeId { get; set; }

        public virtual ProductAttribute Attribute { get; set; }

        public long ProductId { get; set; }

        public Product Product { get; set; }

        public string Value { get; set; }
    }
}
