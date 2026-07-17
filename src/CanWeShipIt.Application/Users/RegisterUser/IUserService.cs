using CanWeShipIt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanWeShipIt.Application.Users.RegisterUser
{
    public interface IUserService
    {
        Task<User> Register(RegisterUserRequest request);
    }
}