using Mentrello.Data.Repositories;
using Mentrello.Domain.Models;
using Mentrello.Services.Adapters;
using Mentrello.Services.Interfaces;

namespace Mentrello.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserAdapter _userAdapter;

        public UserService(IUserRepository userRepository, IUserAdapter userAdapter)
        {
            _userRepository = userRepository;
            _userAdapter = userAdapter;
        }

        public User Create(User user)
        {
            return _userRepository.Create(user);
        }

        public User GetByUsername(string username)
        {
            //validate username/email
            return _userRepository.GetUserByUsername(username);
        }

        public User Update(User existingUser)
        {
            return _userRepository.Update(existingUser);
        }
    }
}
