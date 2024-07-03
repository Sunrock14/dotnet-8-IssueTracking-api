using IssueTracking.Core.BaseRepository;
using IssueTracking.Core.Entities;

namespace IssueTracking.Entities.Models;

public class Project : BaseEntity, IEntity
{
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    //public ICollection<Issue>? Issues { get; set; }
}
