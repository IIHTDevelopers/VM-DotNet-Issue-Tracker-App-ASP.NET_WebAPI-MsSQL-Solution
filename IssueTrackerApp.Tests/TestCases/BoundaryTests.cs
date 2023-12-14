
using IssueTrackerApp.DAL.Interrfaces;
using IssueTrackerApp.DAL.Services;
using IssueTrackerApp.DAL.Services.Repository;
using IssueTrackerApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace IssueTrackerApp.Tests.TestCases
{
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IIssueTrackerService _IssueService;
        public readonly Mock<IIssueTrackerRepository> Issueservice = new Mock<IIssueTrackerRepository>();

        private readonly Issue _Issue;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
        {
            _IssueService = new IssueTrackerService(Issueservice.Object);

            _output = output;

            _Issue = new Issue
            {
                Id= 1,
                CreatedAt= DateTime.Now,
                UpdatedAt= DateTime.Now,
                IsOpen= false,
                Title = "Bug in Login Page",
                Description = "Users unable to login.",
                AssignedTo = "JohnDoe"
            };
        }

        [Fact]
        public async Task<bool> Testfor_Description_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Issueservice.Setup(repo => repo.CreateIssue(_Issue)).ReturnsAsync(_Issue);
                var result = await _IssueService.CreateIssue(_Issue);
                var actualLength = _Issue.Description.ToString().Length;
                if (result.Description.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_IssueId_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Issueservice.Setup(repo => repo.CreateIssue(_Issue)).ReturnsAsync(_Issue);
                var result = await _IssueService.CreateIssue(_Issue);
                var actualLength = _Issue.Id.ToString().Length;
                if (result.Id.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_CreatedDate_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Issueservice.Setup(repo => repo.CreateIssue(_Issue)).ReturnsAsync(_Issue);
                var result = await _IssueService.CreateIssue(_Issue);
                var actualLength = _Issue.CreatedAt.ToString().Length;
                if (result.CreatedAt.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_UpdatedDate_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Issueservice.Setup(repo => repo.CreateIssue(_Issue)).ReturnsAsync(_Issue);
                var result = await _IssueService.CreateIssue(_Issue);
                var actualLength = _Issue.UpdatedAt.ToString().Length;
                if (result.UpdatedAt.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
       

    }
}