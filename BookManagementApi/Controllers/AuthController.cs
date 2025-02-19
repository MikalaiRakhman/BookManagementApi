using BookManagement.DataAccess;
using BookManagement.DataAccess.Data;
using BookManagement.DataAccess.Identity;
using BookManagement.DataAccess.Identity.IdentityModels;
using BookManagement.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly TokenProvider _tokenProvider;

        public AuthController(UserManager<User> userManager, ApplicationDbContext context, TokenProvider tokenProvider)
        {
            _context = context;
            _userManager = userManager;
            _tokenProvider = tokenProvider;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var user = new User
            {
                Email = model.Email,
                UserName = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            await _context.SaveChangesAsync();

            return Ok(new { Message = "User registered successfully!" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            Guard.AgainstUnauthorized(user);

            var isValidPassword = await _userManager.CheckPasswordAsync(user, model.Password);
            Guard.AgainsInvalidPassword(isValidPassword);

            var token = _tokenProvider.GenerateJwtToken(user);

            var refreshToken = _tokenProvider.GenerateRefreshToken(user.Id, cancellationToken);

            return Ok(new { Token = token, RefreshToken = refreshToken.Result });
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenModel model, CancellationToken cancellationToken)
        {
            var (newJwtToken, newRefreshToken) = await _tokenProvider.RefreshTokens(model.RefreshToken, cancellationToken);

            return Ok(new { Token = newJwtToken, RefreshToken = newRefreshToken });
        }
    }
}
