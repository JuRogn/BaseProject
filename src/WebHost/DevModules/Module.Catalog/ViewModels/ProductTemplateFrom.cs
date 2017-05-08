using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Module.Catalog.ViewModels
{
    public class ProductTemplateFrom
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IList<ProductAttributeVm> Attributes { get; set; } = new List<ProductAttributeVm>();
    }
}
