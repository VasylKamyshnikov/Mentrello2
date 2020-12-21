using System.Threading.Tasks;
using Mentrello.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace Mentrello.API.Settings
{
    public class AuthManager : OAuthEvents
    {
        private readonly IUserService _userService;

        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }

        public override Task TicketReceived(TicketReceivedContext context)
        {
            //var tasd = base.TicketReceived(context);

            var user = context.Principal.Claims;

            _userService.GenerateToken("asd");

            return Task.FromResult("hello");
        }
    }
}
