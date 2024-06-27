namespace IssueTracking.Entities.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    // Role relationship
    public int RoleId { get; set; }
    public Role Role { get; set; }

    public List<Issue> ReportedIssues { get; set; }

    public List<IssueAssignee> IssueAssignees { get; set; }
}
