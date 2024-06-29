using IssueTracking.Core.BaseRepository;
using IssueTracking.Data.Repositories.Abstract;
using IssueTracking.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracking.Data.Repositories.Concrete;

public class FileAttachmentRepository : EntityRepository<FileAttachment>, IFileAttachmentRepository
{
    public FileAttachmentRepository(DbContext context) : base(context)
    {
    }
}
