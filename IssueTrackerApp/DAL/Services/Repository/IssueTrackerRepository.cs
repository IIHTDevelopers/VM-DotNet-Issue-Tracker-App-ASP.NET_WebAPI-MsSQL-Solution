using IssueTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace IssueTrackerApp.DAL.Services.Repository
{
    public class IssueTrackerRepository : IIssueTrackerRepository
    {
        private readonly DatabaseContext _dbContext;
        public IssueTrackerRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Issue> CreateIssue(Issue issue)
        {
            try
            {
                var result = _dbContext.Issues.Add(issue);
                await _dbContext.SaveChangesAsync();
                return issue;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeleteIssueById(long id)
        {
            try
            {
                _dbContext.Issues.Remove(_dbContext.Issues.Single(a => a.Id == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Issue> GetAllIssues()
        {
            try
            {
                var result = _dbContext.Issues.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Issue> GetIssueById(long id)
        {
            try
            {
                return await _dbContext.Issues.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }       

        public async Task<Issue> UpdateIssue(Issue model)
        {
            var ex = await _dbContext.Issues.FindAsync(model.Id);
            try
            {
                await _dbContext.SaveChangesAsync();
                return ex;
            }
            catch (Exception exc)
            {
                throw (exc);
            }
        }
    }
}