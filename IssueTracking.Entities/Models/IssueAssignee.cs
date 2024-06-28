using IssueTracking.Core.BaseRepository;

namespace IssueTracking.Entities.Models;

public class IssueAssignee : IEntity
{
    public int IssueId { get; set; }
    public Issue Issue { get; set; } = new();

    public int UserId { get; set; }
    public User User { get; set; } = new();
}
