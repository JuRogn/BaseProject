using System.Collections.Generic;
using Module.Catalog.Models;
using Module.Catalog.ViewModels;

namespace Module.Catalog.Services
{
    public interface ICategoryService
    {
        IList<CategoryListItem> GetAll();

        void Create(Category category);

        void Update(Category category);

        void Delete(Category category);
    }
}
