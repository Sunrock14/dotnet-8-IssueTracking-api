using IssueTracking.Core.BaseRepository;

namespace IssueTracking.Entities.Models;

public class TimeEntry : IEntity
{
    public int Id { get; set; }
    public double Hours { get; set; }
    public DateTime Date { get; set; }
    public string Comment { get; set; } = string.Empty;

    //public int IssueId { get; set; }
    //public Issue Issue { get; set; } = new();

    //public int UserId { get; set; }
    //public User User { get; set; } = new();
}
