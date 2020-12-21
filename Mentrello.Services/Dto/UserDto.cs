using Mentrello.Domain.Models;
using Newtonsoft.Json;

namespace Mentrello.Services.Dto
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("given_name")]
        public string FirstName { get; set; }
        [JsonProperty("family_name")]
        public string LastName { get; set; }
        [JsonProperty("picture")]
        public string PictureUrl { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
    }
    public class UserRole
    {
    }
}
