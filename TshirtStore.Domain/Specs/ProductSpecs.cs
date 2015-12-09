using System;
using System.Linq.Expressions;
using TshirtStore.Domain.Entities;

namespace TshirtStore.Domain.Specs
{
    public static class ProductSpecs
    {
        public static Expression<Func<Product, bool>> GetProductInStock()
        {
            return x => x.QuantityOnhand > 0;
        }
        public static Expression<Func<Product, bool>> GetProductOutOfStock()
        {
            return x => x.QuantityOnhand == 0;
        }
    }
}
