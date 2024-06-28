namespace IssueTracking.Entities.Models;

public class Status
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<Issue>? Issues { get; set; }
}
