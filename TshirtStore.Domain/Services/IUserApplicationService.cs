using TshirtStore.Domain.Commands.UserCommands;
using TshirtStore.Domain.Entities;

namespace TshirtStore.Domain.Services
{
    public interface IUserApplicationService
    {
        User Register(RegisterUserCommand command);
        User Authenticate(string email, string password);
    }
}
