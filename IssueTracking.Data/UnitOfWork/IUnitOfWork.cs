using IssueTracking.Data.Repositories.Abstract;

namespace IssueTracking.Data.UnitOfWork;

public interface IUnitOfWork : IAsyncDisposable
{
    ICommentRepository Comment { get; }
    IFileAttachmentRepository FileAttachment { get; }
    IIssueAssigneeRepository IssueAssignee { get; }
    IIssueRepository Issue { get; }
    IProjectRepository Project { get; }
    IPriorityRepository Priority { get; }
    IRoleRepository Role { get; }
    IStatusRepository Status { get; }
    ITimeEntryRepository TimeEntry { get; }
    IUserRepository User { get; }

    Task<int> SaveAsync();

}
