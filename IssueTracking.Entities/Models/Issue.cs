namespace IssueTracking.Entities.Models;

public class Issue
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DueDate { get; set; }

    // Foreign keys
    public int ProjectId { get; set; }
    public Project Project { get; set; }

    public int StatusId { get; set; }
    public Status Status { get; set; }

    public int PriorityId { get; set; }
    public Priority Priority { get; set; }

    public int ReporterId { get; set; }
    public User Reporter { get; set; }

    public List<Comment> Comments { get; set; }
    public List<FileAttachment> Attachments { get; set; }
    public List<TimeEntry> TimeEntries { get; set; }

    public List<IssueAssignee> IssueAssignees { get; set; }
}
