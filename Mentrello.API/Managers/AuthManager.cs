using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Mentrello.API.Settings;
using Mentrello.Domain.Models;
using Mentrello.Services.Adapters;
using Mentrello.Services.Dto;
using Mentrello.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Mentrello.API.Managers
{
    public class AuthManager : OAuthEvents
    {
        private readonly IUserService _userService;
        private readonly IUserAdapter _userAdapter;
        private readonly JwtTokenSettings _jwtTokenSettings;

        public AuthManager(IUserService userService, IUserAdapter userAdapter, IOptions<JwtTokenSettings> jwtTokenSettings)
        {
            _userService = userService;
            _userAdapter = userAdapter;
            _jwtTokenSettings = jwtTokenSettings.Value;
        }

        public override Task TicketReceived(TicketReceivedContext context)
        {
            var userDto = new UserDto
            {
                Username = context.Principal.Claims.FirstOrDefault(x => x.Type.Contains("email")).Value,
                FirstName = context.Principal.Claims.FirstOrDefault(x => x.Type.Contains("givenname")).Value,
                LastName = context.Principal.Claims.FirstOrDefault(x => x.Type.Contains("surname")).Value
            };

            var existingUser = _userService.GetByUsername(userDto.Username);
            if (existingUser == null)
            {
                var user = _userAdapter.ConvertToEntity(userDto);
                user.Token = GenerateJwtToken(user);

                existingUser = _userService.Create(user);
            }
            else
            {
                if (DateTime.UtcNow > existingUser.Token.ExpirationDate)
                {
                    existingUser.Token = GenerateJwtToken(existingUser);
                    _userService.Update(existingUser);
                }
            }
            context.Request.Headers.Add("Bearer", existingUser.Token.TokenString);

            return Task.FromResult(context);
        }

        private Token GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtTokenSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _jwtTokenSettings.Issuer,
                Subject = new ClaimsIdentity(new Claim[]
                {
                            new Claim("Username", user.Username),
                            new Claim("FirstName", user.FirstName),
                            new Claim("LastName", user.LastName),
                            new Claim("UserId", user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return new Token
            {
                UserId = user.Id.ToString(),
                TokenString = tokenHandler.WriteToken(token),
                ExpirationDate = token.ValidTo
            };
        }
    }
}
