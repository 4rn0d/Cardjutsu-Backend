using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host.Mef;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Super_Cartes_Infinies.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        readonly UserManager<IdentityUser> UserManager;
        readonly ApplicationDbContext _context;
        readonly SignInManager<IdentityUser> SignInManager;
        private readonly PlayersService _servicePlayer;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, PlayersService playersService)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            _context = context;
            _servicePlayer = playersService;
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterDTO register)
        {
            if (register.Password != register.PasswordConfirm)
            {
                return StatusCode(StatusCodes.Status400BadRequest,
                    new { Message = "Les deux mots de passe spécifiés sont différents." });
            }
            IdentityUser user = new IdentityUser()
            {
                UserName = register.Email,
                Email = register.Email
            };
        
            IdentityResult identityResult = await this.UserManager.CreateAsync(user, register.Password);
            if (!identityResult.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new { Message = "La création de l'utilisateur a échoué." });
            }
            _servicePlayer.CreatePlayer(user);
          

            return Ok(new { Message = "Inscription réussie" });
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginDTO login)
        {
            var result = await SignInManager.PasswordSignInAsync(login.Username, login.Password,true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return Ok();
            }

            return NotFound(new { Error = "L'utilisateur est introuvable ou le mot de passe de concorde pas" });
        }

        [Authorize]
        public ActionResult<string[]> PrivateData()
        {
            return new string[] { "figue", "banane", "noix" };
        }

        public ActionResult<string[]> PublicData()
        {
            return new string[] { "chien", "chat", "loutre" };
        }

        public async Task<ActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            return Ok();
        }


        [Authorize]
        public IdentityUser GetUsername()
        {
            
            string Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //IdentityUser? user = await UserManager.FindByIdAsync(Id);

            IdentityUser? user = _context.Users.Find(Id);
            
            //IdentityUser? user = await _context.Users.FindAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return user;
           
        }
    }

    }


