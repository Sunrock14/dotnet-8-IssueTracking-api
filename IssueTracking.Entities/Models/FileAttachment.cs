using IssueTracking.Core.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracking.Entities.Models;

public class FileAttachment : IEntity
{
    public int Id { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string FilePath { get; set; } = string.Empty;
    public DateTime UploadedAt { get; set; } = DateTime.Now;

    //public int IssueId { get; set; }
    //public Issue Issue { get; set; } = new();
}
