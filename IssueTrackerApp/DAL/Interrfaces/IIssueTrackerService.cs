using IssueTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackerApp.DAL.Interrfaces
{
    public interface IIssueTrackerService
    {
        List<Issue> GetAllIssues();
        Task<Issue> CreateIssue(Issue issue);
        Task<Issue> GetIssueById(long id);
        Task<bool> DeleteIssueById(long id);
        Task<Issue> UpdateIssue(Issue model);
    }
}
