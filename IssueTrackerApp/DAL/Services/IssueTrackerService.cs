using IssueTrackerApp.DAL.Interrfaces;
using IssueTrackerApp.DAL.Services.Repository;
using IssueTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace IssueTrackerApp.DAL.Services
{
    public class IssueTrackerService : IIssueTrackerService
    {
        private readonly IIssueTrackerRepository _repository;

        public IssueTrackerService(IIssueTrackerRepository repository)
        {
            _repository = repository;
        }

        public Task<Issue> CreateIssue(Issue issue)
        {
            return _repository.CreateIssue(issue);
        }

        public Task<bool> DeleteIssueById(long id)
        {
            return _repository.DeleteIssueById(id);
        }

        public List<Issue> GetAllIssues()
        {
            return _repository.GetAllIssues();
        }

        public Task<Issue> GetIssueById(long id)
        {
            return _repository.GetIssueById(id);
        }

        public Task<Issue> UpdateIssue(Issue model)
        {
            return _repository.UpdateIssue(model);
        }
    }
}