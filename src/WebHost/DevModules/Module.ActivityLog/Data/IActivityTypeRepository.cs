using System.Linq;
using Infrastructure.Data;
using Module.ActivityLog.Models;

namespace Module.ActivityLog.Data
{
    public interface IActivityTypeRepository : IRepository<Activity>
    {
        IQueryable<MostViewEntityDto> List();
    }
}
