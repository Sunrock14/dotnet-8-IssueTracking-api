namespace IssueTracking.Entities.Models;

public class Priority
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Issue> Issues { get; set; }
}
