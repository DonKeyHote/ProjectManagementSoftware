using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectManagementSoftware.Models;

namespace ProjectManagementSoftware.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // public DbSet<ProjectManagementSoftware.Models.Project> Project { get; set; }
        // public DbSet<ProjectManagementSoftware.Models.UseCase> UseCase { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            
            
            //builder.Property<string>().Configure(c => c.HasColumnType("varchar"));
            // builder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            // builder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<ProjectManagementSoftware.Models.Project> Project { get; set; }

        public DbSet<ProjectManagementSoftware.Models.UseCase> UseCase { get; set; }
    }
}