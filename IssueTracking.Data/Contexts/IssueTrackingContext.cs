using IssueTracking.Data.Mappings;
using IssueTracking.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracking.Data.Contexts;

public class TaskTrackingContext : DbContext
{
    public DbSet<Project> Projects { get; set; }
    public DbSet<Issue> Issues { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<FileAttachment> FileAttachments { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<Priority> Priorities { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<TimeEntry> TimeEntries { get; set; }
    public DbSet<IssueAssignee> IssueAssignees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CommentMap());
        modelBuilder.ApplyConfiguration(new FileAttachmentMap());
        modelBuilder.ApplyConfiguration(new IssueAssingneeMap());
        modelBuilder.ApplyConfiguration(new IssueMap());
        modelBuilder.ApplyConfiguration(new PriorityMap());
        modelBuilder.ApplyConfiguration(new ProjectMap());
        modelBuilder.ApplyConfiguration(new RoleMap());
        modelBuilder.ApplyConfiguration(new StatusMap());
        modelBuilder.ApplyConfiguration(new TimeEntryMap());
        modelBuilder.ApplyConfiguration(new UserMap());
    }
}
