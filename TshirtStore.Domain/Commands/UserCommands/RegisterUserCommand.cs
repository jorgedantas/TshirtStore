namespace TshirtStore.Domain.Commands.UserCommands
{
    public class RegisterUserCommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }


        public RegisterUserCommand(string email, string password, bool isaAdmin)
        {
            this.Email = email;
            this.Password = password;
            this.IsAdmin = isaAdmin;
        }
    }
}
