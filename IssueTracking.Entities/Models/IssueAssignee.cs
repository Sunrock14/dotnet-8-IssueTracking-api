namespace IssueTracking.Entities.Models;

public class IssueAssignee
{
    public int IssueId { get; set; }
    public Issue Issue { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}
