using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripleG.Server.Models;

namespace TripleG.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<ParentInfo> ParentInfo { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Result> Result { get; set; }
        public virtual DbSet<Staffs> Staffs { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentHub> StudentHub { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<StudentResult> StudentResult { get; set; }
        public DbSet<TripleG.Server.Models.UserRole> UserRole { get; set; }
        public DbSet<TripleG.Server.Models.Role> Role { get; set; }

    }
}
