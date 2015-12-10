using TshirtStore.Domain.Scopes;
using TshirtStore.SharedKernel.Helper;

namespace TshirtStore.Domain.Entities
{
    public class User
    {
        protected User()
        {
            
        }
        public User(string email,string password, bool isAdmin)
        {
            this.Email = email;
            this.Password = StringHelper.Encrypt(password);
            // Remover e colocar no controle depois
            this.IsAdmin = isAdmin;
        }

        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool IsAdmin { get; private  set; }

        public void Register()
        {
            this.RegisterUserScopeIsValid();

        }

        public void Authenticate(string email, string password)
        {
            this.AuthenticatiteUsuarioScopeIsValid(email, password);

        }

        public void GrantAdmin()
        {
            this.IsAdmin = true;
        }

        public void RevokeAdmin()
        {
            this.IsAdmin = false;
        }
    }
}
