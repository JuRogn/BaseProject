﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Module.Cms.ViewModels
{
    public class CarouselWidgetItemForm
    {
        public string Image { get; set; }

        public string ImageUrl { get; set; }

        [JsonIgnore]
        public IFormFile UploadImage { get; set; }

        public string Caption { get; set; }

        public string TargetUrl { get; set; }
    }
}
