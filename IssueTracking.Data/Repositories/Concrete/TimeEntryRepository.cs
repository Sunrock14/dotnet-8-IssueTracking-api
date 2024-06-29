using IssueTracking.Core.BaseRepository;
using IssueTracking.Data.Repositories.Abstract;
using IssueTracking.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracking.Data.Repositories.Concrete;

public class TimeEntryRepository : EntityRepository<TimeEntry>, ITimeEntryRepository
{
    public TimeEntryRepository(DbContext context) : base(context)
    {
    }
}
