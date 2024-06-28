using IssueTracking.Core.BaseRepository;

namespace IssueTracking.Entities.Models;

public class Role: IEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<User>? Users { get; set; }
}
