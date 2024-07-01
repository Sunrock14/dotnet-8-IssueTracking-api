using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracking.Services.Businesses.Comment
{
    internal interface ICommentService
    {
        Task<int> AddComment();
        Task<int> DeleteComment();
        Task<int> UpdateComment();
    }
}
