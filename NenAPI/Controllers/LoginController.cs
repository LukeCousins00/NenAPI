using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NenAPI.Entities;

namespace NenAPI.Controllers;

public class LoginController : ControllerBase
{
    UserManager<IdentityUser> _userManager;


    public LoginController(UserManager<IdentityUser> userManager)
    {
       _userManager = userManager;
    }

    [HttpGet]
    public async Task Get([FromRoute] string username, [FromRoute] string password)
    {
        var user = new IdentityUser { UserName = username, Email = username };
        var result = await _userManager.CreateAsync(user, password);


        if (!_userManager.Options.SignIn.RequireConfirmedAccount)
        {
            // send back OK and sign in user 
        }
    }
}
