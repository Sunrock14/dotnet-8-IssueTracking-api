using IssueTracking.Core.BaseRepository;

namespace IssueTracking.Entities.Models;

public class User : IEntity
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    //public int RoleId { get; set; }
    //public Role Role { get; set; } = new();

    //public ICollection<Issue>? ReportedIssues { get; set; }

    public ICollection<IssueAssignee>? IssueAssignees { get; set; }
    //public ICollection<Comment>? Comments{ get; set; }
}
