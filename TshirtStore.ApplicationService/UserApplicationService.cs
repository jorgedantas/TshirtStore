using TshirtStore.Domain.Commands.UserCommands;
using TshirtStore.Domain.Entities;
using TshirtStore.Domain.Repositories;
using TshirtStore.Domain.Services;
using TshirtStore.Infra.Persistence;

namespace TshirtStore.ApplicationService
{
    public class UserApplicationService : ApplicationService , IUserApplicationService
    {
        private IUserRepository _repository;

        public UserApplicationService(IUserRepository repository,IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = repository;
        }

        public User Register(RegisterUserCommand command)
        {
            var user = new User(command.Email,command.Password,command.IsAdmin);
            user.Register();
            _repository.Register(user);

            if (Commit())
                return user;

            return null;


        }

        public User Authenticate(string email, string password)
        {
            return _repository.Authenticate(email, password);
        }
    }
}
