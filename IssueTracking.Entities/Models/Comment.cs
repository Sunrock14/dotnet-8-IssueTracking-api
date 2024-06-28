using IssueTracking.Core.BaseRepository;

namespace IssueTracking.Entities.Models;

public class Comment : IEntity
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }

    public int IssueId { get; set; }
    public Issue Issue { get; set; } = new();

    public int UserId { get; set; }
    public User User { get; set; } = new(); 
}
