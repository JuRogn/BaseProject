﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using Module.Core.Models;

namespace Module.Core.Services
{
    public class WidgetInstanceService : IWidgetInstanceService
    {
        private IRepository<WidgetInstance> _widgetInstanceRepository;

        public WidgetInstanceService(IRepository<WidgetInstance> widgetInstanceRepository)
        {
            _widgetInstanceRepository = widgetInstanceRepository;
        }

        public IQueryable<WidgetInstance> GetPublished()
        {
            return _widgetInstanceRepository.Query().Include(x => x.Widget).Where(x =>
                x.PublishStart.HasValue && x.PublishStart.Value < DateTimeOffset.Now
                && (!x.PublishEnd.HasValue || x.PublishEnd.Value > DateTimeOffset.Now));
        }
    }
}
