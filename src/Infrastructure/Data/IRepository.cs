using Infrastructure.Models;

namespace Infrastructure.Data
{
    public interface IRepository<T> : IRepositoryWithTypedId<T, long> where T : IEntityWithTypedId<long>
    {
    }
}
