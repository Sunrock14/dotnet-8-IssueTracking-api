using IssueTracking.Core.BaseRepository;
using IssueTracking.Data.Repositories.Abstract;
using IssueTracking.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracking.Data.Repositories.Concrete;

public class RoleRepository : EntityRepository<Role>, IRoleRepository
{
    public RoleRepository(DbContext context) : base(context)
    {
    }
}
