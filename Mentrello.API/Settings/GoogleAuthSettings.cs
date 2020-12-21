namespace Mentrello.API.Settings
{
    public class GoogleAuthSettings
    {
        public const string SectionName = "Authentication:Google";

        public string AuthUrl { get; set; }
        public string TokenUrl { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string CallbackPath { get; set; }
    }
}
