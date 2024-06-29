using IssueTracking.Core.BaseRepository;
using IssueTracking.Data.Repositories.Abstract;
using IssueTracking.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracking.Data.Repositories.Concrete;

public class IssueRepository : EntityRepository<Issue>, IIssueRepository
{
    public IssueRepository(DbContext context) : base(context)
    {
    }
}
