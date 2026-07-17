using CanWeShipIt.Application.Users.RegisterUser;
using Microsoft.AspNetCore.Mvc;

namespace CanWeShipIt.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterUserRequest request)
    {
        var user = await _userService.Register(request);

        return Ok(user);
    }
}