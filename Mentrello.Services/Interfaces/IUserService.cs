using Mentrello.Domain.Models;

namespace Mentrello.Services.Interfaces
{
    public interface IUserService
    {
        User Create(User user);
        User GetByUsername(string username);
        User Update(User existingUser);
    }
}
