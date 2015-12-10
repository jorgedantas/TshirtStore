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
        Category Create(CreateCategoryCommand command);
        Category Update(EditCategoryCommand command);
        Category Delete(int id);
    }
}
