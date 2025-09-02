namespace SmartHomeDbProject.Models
{
    public interface IAuthService
    {
        Task<string> Authenticate(string username, string password);
        Task<bool> Register(string username, string password);
    }
}
