using Infrastructure.Models;

namespace Module.Contacts.Models
{
    public class ContactArea : EntityBase
    {
        public string Name { get; set; }

        public bool IsDeleted { get; set; }
    }
}
