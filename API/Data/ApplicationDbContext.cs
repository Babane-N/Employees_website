using backend.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Diagnostics.Metrics;

namespace API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base() { }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Project> Projects => Set<Project>();
        public DbSet<Assignment> Assignments => Set<Assignment>();
        public DbSet<Employee> Employees => Set<Employee>();
    }
}
