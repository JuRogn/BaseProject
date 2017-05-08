using System.Collections.Generic;
using Module.Core.ViewModels;

namespace Module.Cms.ViewModels
{
    public class CarouselWidgetForm : WidgetFormBase
    {
        public IList<CarouselWidgetItemForm> Items = new List<CarouselWidgetItemForm>();
    }
}
