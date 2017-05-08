using System.Collections.Generic;
using Infrastructure.Models;

namespace Module.Localization.Models
{
    public class Culture : EntityBase
    {
        public string Name { get; set; }

        public IList<Resource> Resources { get; set; }
    }
}
