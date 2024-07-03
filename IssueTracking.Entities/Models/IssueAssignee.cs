using IssueTracking.Core.BaseRepository;
using IssueTracking.Core.Entities;

namespace IssueTracking.Entities.Models;

public class IssueAssignee : BaseEntity, IEntity
{
    public int IssueId { get; set; }
    public Issue Issue { get; set; } = new();

    public int UserId { get; set; }
    public User User { get; set; } = new();
}
