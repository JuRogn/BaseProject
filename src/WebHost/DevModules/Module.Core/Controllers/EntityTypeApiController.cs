﻿using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using Module.Core.Models;

namespace Module.Core.Controllers
{
    [Authorize(Roles = "admin")]
    [Route("api/entity-types")]
    public class EntityTypeApiController : Controller
    {
        private readonly IRepository<EntityType> _entityTypeRepository;

        public EntityTypeApiController(IRepository<EntityType> entityTypeRepository)
        {
            _entityTypeRepository = entityTypeRepository;
        }

        [HttpGet("menuable")]
        public IActionResult GetMenuable()
        {
            var entityTypes = _entityTypeRepository.Query()
                .Where(x => x.IsMenuable)
                .Select(x => new
                {
                    x.Id,
                    x.Name
                });

            return Ok(entityTypes);
        }
    }
}
