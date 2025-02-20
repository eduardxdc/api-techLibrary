namespace TechLibrary.Api.infrastructure.Security.Cryptography
{
    public class BCryptAlgorithm
    {
        public string HashPassword(string password) => BCrypt.Net.BCrypt.HashPassword(password);
    }
}
