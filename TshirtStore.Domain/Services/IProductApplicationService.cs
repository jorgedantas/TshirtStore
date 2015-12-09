using System.Collections.Generic;
using TshirtStore.Domain.Commands.ProductCommands;
using TshirtStore.Domain.Entities;

namespace TshirtStore.Domain.Services
{
   public interface IProductApplicationService
    {
        List<Product> Get();
        List<Product> Get(int skip, int take);
        List<Product> GetOutOfStock();
        Product Get(int id);
        Product Create(CreateProductCommand command);
        Product UpdatebasicInformation(UpdateProductInfoCommand command);
        Product Delete(int id);

    }
}
