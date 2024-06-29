using IssueTracking.Core.BaseRepository;
using IssueTracking.Data.Repositories.Abstract;
using IssueTracking.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracking.Data.Repositories.Concrete;

public class StatusRepository : EntityRepository<Status>, IStatusRepository
{
    public StatusRepository(DbContext context) : base(context)
    {
    }
}
