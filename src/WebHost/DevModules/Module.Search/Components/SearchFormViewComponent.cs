using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using Module.Catalog.Models;
using Module.Search.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Module.Search.Components
{
    public class SearchFormViewComponent : ViewComponent
    {
        private IRepository<Category> _categoryRepository;

        public SearchFormViewComponent(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var model = new SearchForm();
            model.AvailableCategories = _categoryRepository
                .Query()
                .Where(x => x.IsPublished && x.Parent == null)
                .Select(x => new SelectListItem
                {
                    Value = x.SeoTitle,
                    Text = x.Name
                }).ToList();

            model.Query = Request.Query["query"];
            model.Category = Request.Query["category"];

            return View("/Modules/Module.Search/Views/Components/SearchForm.cshtml", model);
        }
    }
}
