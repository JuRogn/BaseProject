﻿using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using Module.Core.Models;

namespace Module.Core.Controllers
{
    [Authorize(Roles = "admin")]
    [Route("api/widget-zones")]
    public class WidgetZoneApiController : Controller
    {
        private readonly IRepository<WidgetZone> _widgetZoneRespository;

        public WidgetZoneApiController(IRepository<WidgetZone> widgetZoneRespository)
        {
            _widgetZoneRespository = widgetZoneRespository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var widgetZones = _widgetZoneRespository.Query().Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description
            }).ToList();

            return Json(widgetZones);
        }
    }
}
