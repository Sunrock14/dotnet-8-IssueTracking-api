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

    //TODO : FluentApi ekle, Map klasörlerine taşı
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IssueAssignee>()
            .HasKey(ia => new { ia.IssueId, ia.UserId });

        modelBuilder.Entity<IssueAssignee>()
            .HasOne(ia => ia.Issue)
            .WithMany(i => i.IssueAssignees)
            .HasForeignKey(ia => ia.IssueId);

        modelBuilder.Entity<IssueAssignee>()
            .HasOne(ia => ia.User)
            .WithMany(u => u.IssueAssignees)
            .HasForeignKey(ia => ia.UserId);
    }
}
