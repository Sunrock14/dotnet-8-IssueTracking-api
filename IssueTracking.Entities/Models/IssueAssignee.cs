using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracking.Entities.Models
{
    public class IssueAssignee
    {
        public int IssueId { get; set; }
        public Issue Issue { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }

}
