﻿using System.Linq;
using MediatR;
using Infrastructure.Data;
using Module.Catalog.Models;
using Module.Core.Events;

namespace Module.Catalog.Events
{
    public class ReviewSummaryChangedHandler : INotificationHandler<ReviewSummaryChanged>
    {
        private readonly IRepository<Product> _productRepository;

        public ReviewSummaryChangedHandler(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public void Handle(ReviewSummaryChanged notification)
        {
            if (notification.EntityTypeId != 3)
            {
                return;
            }

            var product = _productRepository.Query().First(x => x.Id == notification.EntityId);
            product.ReviewsCount = notification.ReviewsCount;
            product.RatingAverage = notification.RatingAverage;
        }
    }
}
