using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracking.Entities.Models
{
    public class FileAttachment
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadedAt { get; set; }

        // Foreign key
        public int IssueId { get; set; }
        public Issue Issue { get; set; }
    }

}
