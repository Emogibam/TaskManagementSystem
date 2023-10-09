namespace Task_Management_System.Configuration
{
    // JwtSettings.cs
    public class JwtSettings
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string SecretKey { get; set; }
    }

}
