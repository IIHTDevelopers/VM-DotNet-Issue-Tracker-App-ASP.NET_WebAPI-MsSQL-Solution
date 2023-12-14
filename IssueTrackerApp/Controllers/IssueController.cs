using IssueTrackerApp.DAL.Interrfaces;
using IssueTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace IssueTrackerApp.Controllers
{
    public class IssueController : ApiController
    {
        private readonly IIssueTrackerService _service;
        public IssueController(IIssueTrackerService service)
        {
            _service = service;
        }
        public IssueController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Issue/CreateIssue")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateIssue([FromBody] Issue model)
        {
            var leaveExists = await _service.GetIssueById(model.Id);
            var result = await _service.CreateIssue(model);
            return Ok(new Response { Status = "Success", Message = "Issue created successfully!" });
        }


        [HttpPut]
        [Route("api/Issue/UpdateIssue")]
        public async Task<IHttpActionResult> UpdateIssue([FromBody] Issue model)
        {
            var result = await _service.UpdateIssue(model);
            return Ok(new Response { Status = "Success", Message = "Issue updated successfully!" });
        }


        [HttpDelete]
        [Route("api/Issue/DeleteIssue")]
        public async Task<IHttpActionResult> DeleteIssue(long id)
        {
            var result = await _service.DeleteIssueById(id);
            return Ok(new Response { Status = "Success", Message = "Issue deleted successfully!" });
        }


        [HttpGet]
        [Route("api/Issue/GetIssueById")]
        public async Task<IHttpActionResult> GetIssueById(long id)
        {
            var expense = await _service.GetIssueById(id);
            return Ok(expense);
        }


        [HttpGet]
        [Route("api/Issue/GetAllIssues")]
        public async Task<IEnumerable<Issue>> GetAllIssues()
        {
            return _service.GetAllIssues();
        }
    }
}
