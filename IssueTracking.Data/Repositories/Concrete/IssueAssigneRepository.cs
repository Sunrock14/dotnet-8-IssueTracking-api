using IssueTracking.Core.BaseRepository;
using IssueTracking.Data.Repositories.Abstract;
using IssueTracking.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracking.Data.Repositories.Concrete;

public class IssueAssigneRepository : EntityRepository<IssueAssignee>, IIssueAssigneeRepository
{
    public IssueAssigneRepository(DbContext context) : base(context)
    {
    }
}
