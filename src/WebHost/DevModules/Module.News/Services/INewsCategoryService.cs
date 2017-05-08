using Module.News.Models;

namespace Module.News.Services
{
    public interface INewsCategoryService
    {
        void Create(NewsCategory category);

        void Update(NewsCategory category);

        void Delete(long id);

        void Delete(NewsCategory category);
    }
}
