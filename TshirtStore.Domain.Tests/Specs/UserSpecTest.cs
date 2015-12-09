using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TshirtStore.Domain.Entities;
using TshirtStore.Domain.Specs;
using TshirtStore.SharedKernel.Helper;

namespace TshirtStore.Domain.Tests.Specs
{
    [TestClass]
    public class UserSpecTest
    {
        private List<User> _users;

        public UserSpecTest()
        {
         this._users = new List<User>();
            _users.Add(new User("jorgedantas@msn.com",StringHelper.Encrypt("123456"),true));   
        }    
        [TestMethod]
        [TestCategory("User Specs - Authenticate")]
        public void ShouldAutenticate()
        {
            var exp = UserSpecs.AuthenticateUser("jorgedantas@msn.com", StringHelper.Encrypt("123456"));
            var user = _users.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null,user);
        }

        [TestMethod]
        [TestCategory("User Specs - Authenticate")]
        public void ShouldNotAutenticateWhenEmailIsWrong()
        {
            var exp = UserSpecs.AuthenticateUser("jorgedantas@gmail.com", "123456");
            var user = _users.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null, user);
        }
        [TestMethod]
        [TestCategory("User Specs - Authenticate")]
        public void ShouldNotAutenticateWhenPasswordIsWrong()
        {
            var exp = UserSpecs.AuthenticateUser("jorgedantas@gmail.com", "1234567");
            var user = _users.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null, user);
        }
    }
}
