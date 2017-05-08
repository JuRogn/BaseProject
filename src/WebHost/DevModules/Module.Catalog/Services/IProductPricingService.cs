using System;
using Module.Catalog.Models;
using Module.Catalog.ViewModels;

namespace Module.Catalog.Services
{
    public interface IProductPricingService
    {
        CalculatedProductPrice CalculateProductPrice(ProductThumbnail productThumbnail);

        CalculatedProductPrice CalculateProductPrice(Product product);

        CalculatedProductPrice CalculateProductPrice(decimal price, decimal? oldPrice, decimal? specialPrice, DateTimeOffset? specialPriceStart, DateTimeOffset? specialPriceEnd);
    }
}
