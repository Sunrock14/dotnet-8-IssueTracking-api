using IssueTracking.Core.BaseRepository;

namespace IssueTracking.Entities.Models;

public class Project : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; } = DateTime.Now;

    public ICollection<Issue>? Issues { get; set; }
}
