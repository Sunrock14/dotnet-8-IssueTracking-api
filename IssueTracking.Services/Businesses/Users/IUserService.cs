using IssueTracking.Entities.Models;

namespace IssueTracking.Services.Businesses.Users;

public interface IUserService
{
    Task<int> GetUsers();
    Task<int> AddUser();
    Task<int> DeleteUser();
    Task<int> Login();
    Task<int> LogOut();
    string GenerateJwtToken(User user);
    string ValidateJwtToken(string token);
}
