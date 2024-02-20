using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using System.Security.Claims;

namespace Super_Cartes_Infinies.Services
{
    public class AccountService
    {
      
        private readonly PlayersService _servicePlayer;
        private readonly IHttpContextAccessor _httpContextAccessor;
        readonly SignInManager<IdentityUser> SignInManager;
        readonly UserManager<IdentityUser> UserManager;

        public AccountService( PlayersService playersService, IHttpContextAccessor httpContextAccessor, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            
            _servicePlayer = playersService;
            _httpContextAccessor = httpContextAccessor;
            UserManager = userManager;
            SignInManager = signInManager;
        }
        //public async Task<IdentityUser?> RegisterUser(RegisterDTO register)
        //{

        //    IdentityUser user = new IdentityUser()
        //    {
        //        UserName = register.Email,
        //        Email = register.Email
        //    };
        //    IdentityResult identityResult = await this.UserManager.CreateAsync(user, register.Password);
        //    if (!identityResult.Succeeded)
        //    {
        //        return Ok;
        //    }
        //    else
        //    {
        //        return user;
        //    }
       
        //}
           
        public async Task<IdentityUser> RegisterPlayer(IdentityUser user)
        {
           
            _servicePlayer.CreatePlayer(user);
            return user;

        }

  
        public async Task<Microsoft.AspNetCore.Identity.SignInResult> Login(LoginDTO login)
        {
            var result = await SignInManager.PasswordSignInAsync(login.Username, login.Password, true, lockoutOnFailure: false);
            return result;
        }

        public async void Logout()
        {
            await SignInManager.SignOutAsync();
           
        }

      
       



    }
}
