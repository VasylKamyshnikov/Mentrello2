using Mentrello.Services.Dto;

namespace Mentrello.Services.Interfaces
{
    public interface IUserService
    {
        AuthResponceDto GenerateToken(string username);
    }
}
