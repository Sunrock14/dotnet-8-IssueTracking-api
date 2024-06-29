using IssueTracking.Core.BaseRepository;
using IssueTracking.Entities.Models;

namespace IssueTracking.Data.Repositories.Abstract;

public interface IIssueRepository : IEntityRepository<Issue>
{
}
