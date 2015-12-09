﻿using System.Collections.Generic;
using System.Linq;
using TshirtStore.Domain.Entities;
using TshirtStore.Domain.Specs;
using TshirtStore.Infra.Persistence.DataContexts;

namespace TshirtStore.Infra.Repositories
{
    public class UserRepository
    {
        private StoreDataContext _context;

        public UserRepository(StoreDataContext context)
        {
            this._context = context;
        }

        public void Register(User user)
        {
            _context.Users.Add(user);
        }

        public User Authenticate(string email, string password)
        {
            return _context.Users
                .Where(UserSpecs.AuthenticateUser(email, password))
                .FirstOrDefault();
        }

        public User GetByEmail(string email)
        {
            return _context.Users
                .Where(UserSpecs.GetByEmail(email))
                .FirstOrDefault();
        }

        public List<User> List()
        {
            return _context.Users.OrderBy(x => x.Email).ToList();
        }
    }
}
