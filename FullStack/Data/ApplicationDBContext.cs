using Microsoft.EntityFrameworkCore;
using FullStack.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FullStack.Data
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<SalesLeadEntity> SalesLead { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Assessment> Assessment { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<UserModules> UserModules { get; set; }
        public DbSet<AttachmentFile> AttachmentFile { get; set; }
    }
}
