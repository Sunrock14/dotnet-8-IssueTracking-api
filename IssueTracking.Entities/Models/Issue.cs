using IssueTracking.Core.BaseRepository;

namespace IssueTracking.Entities.Models;

public class Issue : IEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = String.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public DateTime? DueDate { get; set; } = DateTime.Now;

    //public int ProjectId { get; set; }
    //public Project Project { get; set; } = new();

    //public int StatusId { get; set; }
    //public Status Status { get; set; } = new();

    //public int PriorityId { get; set; }
    //public Priority Priority { get; set; } = new();

    //public int ReporterId { get; set; }
    //public User Reporter { get; set; } = new();

    //public ICollection<Comment>? Comments { get; set; }
    //public ICollection<FileAttachment>? Attachments { get; set; }
    //public ICollection<TimeEntry>? TimeEntries { get; set; }
    public ICollection<IssueAssignee>? IssueAssignees { get; set; }
}
