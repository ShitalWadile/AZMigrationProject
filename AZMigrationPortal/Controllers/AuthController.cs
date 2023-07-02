using AZMigrationPortal.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AZMigrationPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        private readonly ITokenHandler tokenHandler;
        public AuthController(IUserRepository userRepository, ITokenHandler tokenHandler)
        {
            this.userRepository = userRepository;
            this.tokenHandler = tokenHandler;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync(Models.LoginRequest loginRequest)
        {
            //validate the incoming request


            //check wether the user is authenticated
            //check username and password
            var user = await userRepository.AuthenticateAsync(
                loginRequest.UserName, loginRequest.Password);
            if (user !=null )
            {
                //generate jwt token
                var token = await tokenHandler.CreateTokenAsync(user);
                return Ok(token);

            }
            return BadRequest("UserName Or Password Is Incorrect");

        }
    }
}
