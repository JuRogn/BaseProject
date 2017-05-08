using Infrastructure.Data;
using Infrastructure.Models;

namespace Module.Core.Data
{
    public class Repository<T> : RepositoryWithTypedId<T, long>, IRepository<T>
       where T : class, IEntityWithTypedId<long>
    {
        public Repository(SimplDbContext context) : base(context)
        {
        }
    }
}
