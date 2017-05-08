using Infrastructure.Models;

namespace Module.Core.Models
{
    public class AppSetting : EntityBase
    {
        public string Key { get; set; }

        public string Value { get; set; }
    }
}
