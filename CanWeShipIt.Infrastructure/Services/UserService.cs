using CanWeShipIt.Application.Users.RegisterUser;
using CanWeShipIt.Domain.Entities;
using CanWeShipIt.Infrastructure.Persistence;

namespace CanWeShipIt.Infrastructure.Services;

public class UserService : IUserService
{
    private readonly ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<User> Register(RegisterUserRequest request)
    {
        var user = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,

            //left as plain text for review
            Password = request.Password
        };

        _context.Users.Add(user);

        await _context.SaveChangesAsync();

        return user;
    }
}