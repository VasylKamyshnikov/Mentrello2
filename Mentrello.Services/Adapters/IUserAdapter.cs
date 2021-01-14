using System;
using Mentrello.Domain.Models;
using Mentrello.Services.Dto;

namespace Mentrello.Services.Adapters
{
    public interface IUserAdapter
    {
        User ConvertToEntity(UserDto userDto);
        UserDto ConvertToDto(User userDto);
    }

    public class UserAdapter : IUserAdapter
    {
        public UserDto ConvertToDto(User user)
        {
            return new UserDto
            {
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Token = user.Token.TokenString
            };
        }

        public User ConvertToEntity(UserDto userDto)
        {
            return new User
            {
                Username = userDto.Username,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName
            };
        }
    }
}
