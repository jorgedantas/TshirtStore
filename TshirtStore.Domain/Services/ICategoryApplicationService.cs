using System.Collections.Generic;
using TshirtStore.Domain.Commands.CategoryCommands;
using TshirtStore.Domain.Entities;

namespace TshirtStore.Domain.Services
{
    public interface ICategoryApplicationService
    {
        List<Category> Get();
        List<Category> Get(int skip, int take);
        Category Get(int id);
        void Create(CreateCategoryCommand category);
        void Update(EditCategoryCommand category);
        void Delete(int id);
    }
}
