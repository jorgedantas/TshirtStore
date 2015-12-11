using Microsoft.VisualStudio.TestTools.UnitTesting;
using TshirtStore.Domain.Entities;
using TshirtStore.Domain.Scopes;
using TshirtStore.SharedKernel.Helper;

namespace TshirtStore.Domain.Tests.Scopes
{
    /// <summary>
    /// Summary description for UserScope
    /// </summary>
    [TestClass]
    public class UserScopeTests
    {
        private User _validUser = new User("jorgedantas@msn.com", "123456", true);
        private User _invalidPassworduser = new User("jorgedantas@msn.com", "", true);
        private User _invalidEmailuser = new User("", "123456", true);

        [TestMethod]
        [TestCategory("User Scope - Register")]
        public void ShouldRegisterUser()
        {
           Assert.AreEqual(true,UsersScopes.RegisterUserScopeIsValid(_validUser));

        }

        [TestMethod]
        [TestCategory("User Scope - Register")]
        public void ShouldNotRegisterUserWhenPasswordIsInvalid()
        {
            Assert.AreEqual(false, UsersScopes.RegisterUserScopeIsValid(_invalidPassworduser));

        }

        [TestMethod]
        [TestCategory("User Scope - Register")]
        public void ShouldNotRegisterUserWhenEmailIsInvalid()
        {
            Assert.AreEqual(false, UsersScopes.RegisterUserScopeIsValid(_invalidEmailuser));

        }

        [TestMethod]
        [TestCategory("User Scope - Authenticate")]
        public void ShouldAuthenticateUser()
        {

            var isValid = UsersScopes.AuthenticatiteUsuarioScopeIsValid(_validUser, "jorgedantas@msn.com",
                StringHelper.Encrypt("123456"));
            Assert.AreEqual(true,isValid);

        }

        [TestMethod]
        [TestCategory("User Scope - Authenticate")]
        public void ShouldNotAuthenticateUser()
        {

         
            Assert.AreEqual(false, UsersScopes.AuthenticatiteUsuarioScopeIsValid(_validUser, "jorgedantas@msn.com",
                "123456"));

        }
    }
}
