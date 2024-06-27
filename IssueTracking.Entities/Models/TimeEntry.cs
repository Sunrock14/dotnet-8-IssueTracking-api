namespace IssueTracking.Entities.Models;

public class TimeEntry
{
    public int Id { get; set; }
    public double Hours { get; set; }
    public DateTime Date { get; set; }
    public string Comment { get; set; }

    // Foreign key
    public int IssueId { get; set; }
    public Issue Issue { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}
