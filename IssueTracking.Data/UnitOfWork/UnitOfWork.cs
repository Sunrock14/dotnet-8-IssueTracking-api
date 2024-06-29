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

    public ICommentRepository CommentRepository => _commentRepository ??= new CommentRepository(_context);

    public IFileAttachmentRepository FileAttachmentRepository => _fileAttachmentRepository ??= new FileAttachmentRepository(_context);

    public IIssueAssigneeRepository IssueAssigneeRepository => _ıssueAssigneRepository ??= new IssueAssigneRepository(_context);

    public IIssueRepository IssueRepository => _ıssueRepository ??= new IssueRepository(_context);

    public IProjectRepository ProjectRepository => _projectRepository ??= new ProjectRepository(_context);

    public IPriorityRepository PriorityRepository => _priorityRepository??= new PriorityRepository(_context);

    public IRoleRepository RoleRepository => _roleRepository ??= new RoleRepository(_context);

    public IStatusRepository StatusRepository => _statusRepository??= new StatusRepository(_context);

    public ITimeEntryRepository TimeEntryRepository => _timeEntryRepository??= new TimeEntryRepository(_context);

    public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context);

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }
}
