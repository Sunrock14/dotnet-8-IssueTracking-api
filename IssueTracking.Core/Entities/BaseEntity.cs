namespace IssueTracking.Core.Entities;

/// <summary>
/// Modeller için temel özellikleri tutar
/// </summary>
public abstract class BaseEntity
{
    public virtual int Id { get; set; }
    public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
    public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
    public virtual bool IsActive { get; set; } = true;
}
