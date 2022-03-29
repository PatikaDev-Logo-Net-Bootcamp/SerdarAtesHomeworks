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
        public JwtService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "user1","password1"},
            { "user2","password2"},
            { "user3","password3"},
        };
        public TokenDTO Authenticate(UserDTO user)
        {
            if (!users.Any(x => x.Key == user.Name && x.Value == user.Password))
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
