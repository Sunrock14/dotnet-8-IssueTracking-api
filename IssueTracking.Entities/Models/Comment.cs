namespace IssueTracking.Entities.Models;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }

    // Foreign key
    public int IssueId { get; set; }
    public Issue Issue { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}
