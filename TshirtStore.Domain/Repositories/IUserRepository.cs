using System.Globalization;
using TshirtStore.Domain.Entities;

namespace TshirtStore.Domain.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);
        User Authenticate(StringInfo email, string password);
        User GetByEmail(string email);
    }
}
