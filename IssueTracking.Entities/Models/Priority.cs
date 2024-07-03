using IssueTracking.Core.BaseRepository;

namespace IssueTracking.Entities.Models;

public class Priority : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    //public ICollection<Issue>? Issues { get; set; }
}
