using IssueTracking.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IssueTracking.Data.Mappings;

public class IssueAssingneeMap : IEntityTypeConfiguration<IssueAssignee>
{
    public void Configure(EntityTypeBuilder<IssueAssignee> builder)
    {
        throw new NotImplementedException();
    }
}
