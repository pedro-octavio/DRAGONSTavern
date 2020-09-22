using DRAGONSTavern.Domain.Core.Interfaces.Repositories;
using DRAGONSTavern.Domain.Core.Interfaces.Services;
using DRAGONSTavern.Domain.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;

namespace DRAGONSTavern.Domain.Services.Services
{
    public class TokenService : ITokenService
    {
        private readonly IUserRepository _userRepository;

        public TokenService(IUserRepository userRepository) => _userRepository = userRepository;

        public string GenerateToken(User user)
        {
            try
            {
                var userBase = _userRepository.GetByEmail(user.Email);

                if (userBase.Password == user.Password)
                {
                    var tokenHandler = new JwtSecurityTokenHandler();

                    var subject = new ClaimsIdentity(
                    new GenericIdentity(user.Id, "Login"),
                        new[]
                        {
                        new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString("N")),
                        new Claim(JwtRegisteredClaimNames.UniqueName, user.Id.ToString())
                        }
                    );

                    var key = Encoding.ASCII.GetBytes(Settings.secret);

                    var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);

                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = subject,
                        SigningCredentials = signingCredentials,
                        Expires = DateTime.UtcNow.AddHours(1)
                    };

                    var token = tokenHandler.CreateToken(tokenDescriptor);

                    return tokenHandler.WriteToken(token);
                }
                else throw new Exception("Invalid user.");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
