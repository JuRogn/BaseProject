using System.Linq;
using Module.Core.Models;

namespace Module.Core.Services
{
    public interface IWidgetInstanceService
    {
        IQueryable<WidgetInstance> GetPublished();
    }
}
