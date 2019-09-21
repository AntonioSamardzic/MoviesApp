using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projekt.Controllers;
using Projekt.Core.Services.Contracts;
using Projekt.Requests.Auth;
using Projekt.Responses;
using Projekt.Services.Contracts;

namespace Projekt.Controllers.Auth
{
    [Route("/")]
    public class AuthController : AppController
    {
        private readonly IAuthService AuthService;
        private readonly IUserService UserService;

        public AuthController(
            IAuthService authService,
            IUserService userService
            )
        {
            AuthService = authService;
            UserService = userService;
        }
        
        [Route("api/auth/login")]
        [HttpPost]
        public async Task<object> Login([FromBody] LoginRequest request)
        {
            string token = await AuthService.SignInAsync(request.Email, request.Password);

            if(string.IsNullOrEmpty(token))
                throw new ApplicationException("WRONG_EMAIL_PASSWORD");

             return new LoginResponse()
           {
               Token = token,
               User = new LoginReponseUser()
               {
                   Username = request.Email,
                   Email = request.Email
               }
           };
       }
       
       [Route("api/auth/register")]
        [HttpPost]
        public async Task<RegisterResponse> Register([FromBody] RegisterRequest request)
        {
            string token = await AuthService.RegisterAsync(request.Email, request.Password, request.Card, request.FirstName, request.LastName);
            var user = await UserService.getByEmailAsync(request.Email);

            if(string.IsNullOrEmpty(token))
                throw new ApplicationException("WRONG_EMAIL_PASSWORD");
            
            return new RegisterResponse {
                User = new AuthUserResponse {
                    Id = 1,
                    Email = user.Email
                },
                Token = token
            };
        }

        [Authorize]
        [HttpGet]
        public object Protected()
        {
            return "Protected area";
        }
    }
}