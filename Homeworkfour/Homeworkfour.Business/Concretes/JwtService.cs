using Homeworkfour.Business.Abstract;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkfour.Business.DTOs;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Homeworkfour.Business.Concretes
{
    public class JwtService : IJwtService
    {
        private readonly IConfiguration configuration;
        private readonly IUserService userService;
        public JwtService(IConfiguration configuration,IUserService userService)
        {
            this.configuration = configuration;
            this.userService = userService;
        }
     
        public TokenDTO Authenticate(UserDTO user)
        {
            var users = userService.GetAllUsers();
            if (!users.Any(x => x.username == user.Name && x.password == user.Password))
            {
                return null;
            }

            // Else we generate JSON Web Token
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(configuration["JWT:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
              {
             new Claim(ClaimTypes.Name, user.Name)
              }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return new TokenDTO
            {
                Token = tokenHandler.WriteToken(token)
            };
        }
    }
}
