using Core.Business.Abstract;
using Core.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.IsSuccess)
                return BadRequest(userToLogin.Message);

            var result = _authService.CreateAccessToken(userToLogin.Data);
            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.IsSuccess)
                BadRequest(userExists.Message);

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);

            var result = _authService.CreateAccessToken(registerResult.Data);

            return result.IsSuccess ? Ok(result.Data) : BadRequest(result.Message);
        }
    }
}