using Module.Catalog.Models;

namespace Module.Catalog.Services
{
    public interface IProductService
    {
        void Create(Product product);

        void Update(Product product);

        void Delete(Product product);
    }
}
