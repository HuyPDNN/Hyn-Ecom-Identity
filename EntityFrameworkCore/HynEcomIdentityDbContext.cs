using HynEcom.IdentityServer.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace HynEcom.IdentityServer.EntityFrameworkCore
{
#pragma warning disable CS1591
    public class HynEcomIdentityDbContext : DbContext
    {
        public HynEcomIdentityDbContext(DbContextOptions<HynEcomIdentityDbContext> options)
            : base(options)
        {

        }


        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<UserRole> UserRoles { get; set; }

        public virtual DbSet<Permission> Permissions { get; set; }

        public virtual DbSet<BusinessObject> BusinessObjects { get; set; }

        public virtual DbSet<BusinessObjectUser> BusinessObjectUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfiguredBuilder();
        }
    }
#pragma warning restore CS1591
}