using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public interface ICustomModelBuilder
    {
        void Build(ModelBuilder modelBuilder);
    }
}
