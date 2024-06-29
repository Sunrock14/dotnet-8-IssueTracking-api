using IssueTracking.Core.BaseRepository;
using IssueTracking.Data.Repositories.Abstract;
using IssueTracking.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracking.Data.Repositories.Concrete;

public class UserRepository : EntityRepository<User>, IUserRepository
{
    public UserRepository(DbContext context) : base(context)
    {
    }
}
