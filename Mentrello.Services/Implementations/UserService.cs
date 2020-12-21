using Mentrello.Services.Dto;
using Mentrello.Services.Interfaces;

namespace Mentrello.Services.Implementations
{
    public class UserService : IUserService
    {
        public AuthResponceDto GenerateToken(string username)
        {
            return new AuthResponceDto
            {
                Token = "token",
                User = new UserDto
                {
                    UserName = username
                }
            };
        }
    }
}
