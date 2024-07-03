using IssueTracking.Data.Repositories.Abstract;
using IssueTracking.Data.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;

namespace IssueTracking.Data.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly DbContext _context;
    private CommentRepository _commentRepository;
    private FileAttachmentRepository _fileAttachmentRepository;
    private IssueAssigneRepository  _ıssueAssigneRepository;
    private IssueRepository _ıssueRepository;
    private PriorityRepository _priorityRepository;
    private ProjectRepository _projectRepository;
    private RoleRepository _roleRepository;
    private StatusRepository _statusRepository;
    private TimeEntryRepository _timeEntryRepository;
    private UserRepository _userRepository;

    public UnitOfWork(DbContext context)
    {
        _context = context;
    }

    public ICommentRepository Comment => _commentRepository ??= new CommentRepository(_context);

    public IFileAttachmentRepository FileAttachment => _fileAttachmentRepository ??= new FileAttachmentRepository(_context);

    public IIssueAssigneeRepository IssueAssignee => _ıssueAssigneRepository ??= new IssueAssigneRepository(_context);

    public IIssueRepository Issue => _ıssueRepository ??= new IssueRepository(_context);

    public IProjectRepository Project => _projectRepository ??= new ProjectRepository(_context);

    public IPriorityRepository Priority => _priorityRepository??= new PriorityRepository(_context);

    public IRoleRepository Role => _roleRepository ??= new RoleRepository(_context);

    public IStatusRepository Status => _statusRepository??= new StatusRepository(_context);

    public ITimeEntryRepository TimeEntry => _timeEntryRepository??= new TimeEntryRepository(_context);

    public IUserRepository User => _userRepository ??= new UserRepository(_context);

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }
}
