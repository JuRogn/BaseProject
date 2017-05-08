using System.Collections.Generic;
using Infrastructure.Models;
using Module.Core.Models;

namespace Module.Cms.Models
{
    public class MenuItem : EntityBase
    {
        public long? ParentId { get; set; }

        public MenuItem Parent { get; set; }

        public IList<MenuItem> Children { get; protected set; } = new List<MenuItem>();

        public long MenuId { get; set; }

        public Menu Menu { get; set; }

        public long? EntityId { get; set; }

        public Entity Entity { get; set; }

        public string CustomLink { get; set; }

        public string Name { get; set; }
    }
}
