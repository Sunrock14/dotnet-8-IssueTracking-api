using IssueTracking.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracking.Data.UnitOfWork;

public interface IUnitOfWork : IAsyncDisposable
{
    ICommentRepository CommentRepository { get; }
    IFileAttachmentRepository FileAttachmentRepository{ get; }
    IIssueAssigneeRepository IssueAssigneeRepository { get; }
    IIssueRepository IssueRepository  { get; }
    IProjectRepository ProjectRepository  { get; }
    IPriorityRepository PriorityRepository  { get; }
    IRoleRepository RoleRepository  { get; }
    IStatusRepository StatusRepository  { get; }
    ITimeEntryRepository TimeEntryRepository  { get; }
    IUserRepository UserRepository  { get; }

    Task<int> SaveAsync();

}
