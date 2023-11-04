using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Infrastruture.Entities;

namespace TaskManagementSystem.Infrastruture.Context
{
    public abstract class AppDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<UserEmail> Emails { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectMembers> ProjectMembers { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<TaskAssignee> TaskAssignees { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
