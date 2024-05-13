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
        readonly AccountService _accountService;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, PlayersService playersService, AccountService accountService)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            _context = context;
            _servicePlayer = playersService;
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterDTO register)
        {
            if (register.Password != register.PasswordConfirm)
            {
                return StatusCode(StatusCodes.Status400BadRequest,
                    new { Message = "Les deux mots de passe spécifiés sont différents." });
            }
            //IdentityUser? user = await _accountService.RegisterUser(register);
            ////ne px pas le mettre dans le servrice pour traiter les erreur avec les messages
            IdentityUser user = new IdentityUser()
            {
                UserName = register.Email,
                Email = register.Email
            };
            IdentityResult identityResult = await this.UserManager.CreateAsync(user, register.Password);
            if (!identityResult.Succeeded)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    new { Message = identityResult.Errors.First().Description });
            }
          
            if (user == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new { Message = "La création de l'utilisateur a échoué." });
            }
            await _accountService.RegisterPlayer(user);

            return Ok(new { Message = "Inscription réussie" });
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginDTO login)
        {
            var result = await _accountService.Login(login);
            if (result.Succeeded)
            {
                Player player = _servicePlayer.GetPlayerFromUserName(login.Username);
                return Ok(new { Elo = player.EloScore });
            }

            return NotFound(new { Error = "L'utilisateur est introuvable ou le mot de passe de concorde pas" });
        }

        [Authorize]
        public ActionResult<string[]> PrivateData()
        {
            return new string[] { "figue", "banane", "noix" };
        }

      

        public async Task<ActionResult> Logout()
        {
            _accountService.Logout();
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

        [Authorize]
        public Player GetCurrentPlayerId()
        {

            string Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //IdentityUser? user = await UserManager.FindByIdAsync(Id);

            Player? player = _context.Players.Where(p => p.IdentityUserId == Id).FirstOrDefault();

            //IdentityUser? user = await _context.Users.FindAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return player;

        }
    }

    }


