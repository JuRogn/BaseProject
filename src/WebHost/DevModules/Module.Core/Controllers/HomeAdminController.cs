﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Module.Core.Controllers
{
    [Authorize(Roles = "admin, vendor")]
    public class HomeAdminController : Controller
    {
        [Route("admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
