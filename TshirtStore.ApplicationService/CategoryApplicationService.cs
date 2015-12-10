using System.Collections.Generic;
using TshirtStore.Domain.Commands.CategoryCommands;
using TshirtStore.Domain.Entities;
using TshirtStore.Domain.Repositories;
using TshirtStore.Domain.Services;
using TshirtStore.Infra.Persistence;

namespace TshirtStore.ApplicationService
{
    public class CategoryApplicationService : ApplicationService , ICategoryApplicationService
    {
        private ICategoryRepository _repository ;

        public CategoryApplicationService(ICategoryRepository repository,IUnitOfWork unitOfWork) : base (unitOfWork)
        {
            this._repository = repository;
        }

        public List<Category> Get()
        {
            return _repository.Get();
        }

        public List<Category> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public Category Get(int id)
        {
            return _repository.Get(id);
        }

        public Category Create(CreateCategoryCommand command)
        {
           var category = new Category(command.Title);
           category.Register();
           _repository.Create(category);

            if (Commit())
                return category;
            return null;
        }

        public Category Update(EditCategoryCommand command)
        {
            var category = _repository.Get(command.Id);
            category.UpdateTitle(command.Title);
            _repository.Update(category);

            if (Commit())
                return category;

            return null;
        }

        public Category Delete(int id)
        {
            var category = _repository.Get(id);
            _repository.Delete(category);

            if (Commit())
                return category;

            return null;
        }
    }
}
