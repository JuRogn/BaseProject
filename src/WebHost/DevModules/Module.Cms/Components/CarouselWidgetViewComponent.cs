using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Module.Cms.ViewModels;
using Module.Core.Services;
using Module.Core.ViewModels;

namespace Module.Cms.Components
{
    public class CarouselWidgetViewComponent : ViewComponent
    {
        private IMediaService _mediaService;

        public CarouselWidgetViewComponent(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        public IViewComponentResult Invoke(WidgetInstanceViewModel widgetInstance)
        {
            var model = new CarouselWidgetViewComponentVm
            {
                Id = widgetInstance.Id,
                Items = JsonConvert.DeserializeObject<IList<CarouselWidgetViewComponentItemVm>>(widgetInstance.Data)
            };

            foreach (var item in model.Items)
            {
                item.Image = _mediaService.GetMediaUrl(item.Image);
            }

            return View("/Modules/Module.Cms/Views/Components/CarouselWidget.cshtml", model);
        }
    }
}
