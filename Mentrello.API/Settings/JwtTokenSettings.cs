namespace Mentrello.API.Settings
{
    public class JwtTokenSettings
    {
        public const string SectionName = "Authentication:Jwt";

        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string Secret { get; set; }
    }
}
