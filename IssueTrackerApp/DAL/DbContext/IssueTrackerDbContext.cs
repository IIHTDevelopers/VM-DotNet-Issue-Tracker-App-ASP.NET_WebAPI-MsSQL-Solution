
using IssueTrackerApp.Models;
using System.Data.Entity;


namespace IssueTrackerApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<Issue> Issues { get; set; }
    }
}