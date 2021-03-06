﻿using System.Collections.Generic;
using System.Globalization;
using TshirtStore.Domain.Entities;

namespace TshirtStore.Domain.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);
        User Authenticate(string email, string password);
        User GetByEmail(string email);
        List<User> List();
    }
}
