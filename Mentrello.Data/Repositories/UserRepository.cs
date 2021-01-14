using System.Linq;
using Mentrello.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Mentrello.Data.Repositories
{
    public interface IUserRepository
    {
        User GetUserByUsername(string username);
        User Create(User userEntity);
        User Update(User existingUser);
    }

    public class UserRepository : IUserRepository
    {
        private readonly MentrelloContext _context;
        private readonly DbSet<User> _users;

        public UserRepository(MentrelloContext context)
        {
            _context = context;
            _users = _context.Set<User>();
        }

        public User Create(User userEntity)
        {
            _users.Add(userEntity);
            _context.SaveChanges();

            return userEntity;
        }

        public User GetUserByUsername(string username)
        {
            return _users.FirstOrDefault(x => x.Username == username);
        }

        public User Update(User userForUpdate)
        {
            _users.Update(userForUpdate);
            _context.SaveChanges();

            return userForUpdate;
        }
    }
}
