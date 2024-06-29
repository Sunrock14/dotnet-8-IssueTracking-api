using IssueTracking.Core.BaseRepository;
using IssueTracking.Data.Repositories.Abstract;
using IssueTracking.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracking.Data.Repositories.Concrete;

public class PriorityRepository : EntityRepository<Priority>, IPriorityRepository
{
    public PriorityRepository(DbContext context) : base(context)
    {
    }
}
