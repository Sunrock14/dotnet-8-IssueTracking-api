using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracking.Services.Businesses.Issue
{
    public interface IIssueService
    {
        Task<int> TaskDetail(int id);
        Task<int> GetAllTask(int userId);
        Task<int> CloseTask(int id);
        Task<int> UpdateTask(int id);
        Task<int> FindTask(string searchText);
        Task<int> AssigneeTask(string searchText);
    }
}
