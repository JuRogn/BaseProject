﻿using System.Linq;
using Module.ActivityLog.Models;
using Module.Core.Data;
using Module.Core.Models;

namespace Module.ActivityLog.Data
{
    public class ActivityRepository : Repository<Activity>, IActivityTypeRepository
    {
        private const int MostViewActivityTypeId = 1;

        public ActivityRepository(SimplDbContext context) : base(context)
        {
        }

        public IQueryable<MostViewEntityDto> List()
        {
            return from a in DbSet
                join e in Context.Set<Entity>() on new { a.EntityId, a.EntityTypeId } equals new { e.EntityId, e.EntityTypeId }
                where a.ActivityTypeId == MostViewActivityTypeId
                group a by new {a.EntityId, a.EntityTypeId, e.Name, e.Slug}
                into g
                orderby g.Count() descending
                select new MostViewEntityDto
                {
                    EntityTypeId = g.Key.EntityTypeId,
                    EntityId = g.Key.EntityId,
                    Name = g.Key.Name,
                    Slug = g.Key.Slug,
                    ViewedCount = g.Count()
                };
        }
    }
}
