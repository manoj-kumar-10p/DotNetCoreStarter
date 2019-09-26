using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Api.Core.Entity;

namespace Api.Core.DbContext
{
    public class ApiContext : IdentityDbContext<ApplicationUser, ApplicationRole, long>
    {
        public ApiContext(DbContextOptions options)
       : base(options)
        {

        }
        public DbSet<TestTable> TestTable { get; set; }
        public DbSet<AuthStore> AuthStore { get; set; }
        public DbSet<Car> Car { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.EntityRelationships(builder);
        }

        private void EntityRelationships(ModelBuilder builder) // Apply Relationships
        {
           // builder.ApplyConfiguration(new ApplicationUserConfig());
        }
    }
}
