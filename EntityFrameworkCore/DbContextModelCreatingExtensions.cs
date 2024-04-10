using HynEcom.IdentityServer.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace HynEcom.IdentityServer.EntityFrameworkCore
{
    public static class DbContextModelCreatingExtensions
    {
        public static void ConfiguredBuilder(this ModelBuilder builder)
        {
            builder.Entity<User>(b =>
            {
                b.ToTable("Users", DbProperties.DbSchemaIdentity);
            });

            builder.Entity<Role>(b =>
            {
                b.ToTable("Roles", DbProperties.DbSchemaIdentity);
            });

            builder.Entity<UserRole>(b =>
            {
                b.ToTable("UserRoles", DbProperties.DbSchemaIdentity);
            });

            builder.Entity<Permission>(b =>
            {
                b.ToTable("Permissions", DbProperties.DbSchemaIdentity);
            });

            builder.Entity<BusinessObject>(b =>
            {
                b.ToTable("BusinessObjects", DbProperties.DbSchemaIdentity);
            });

            builder.Entity<BusinessObjectUser>(b =>
            {
                b.ToTable("BusinessObjectUsers", DbProperties.DbSchemaIdentity);
            });

            builder.Entity<UserRole>().HasKey(table => new
            {
                table.RoleId,
                table.UserId
            });
        }
    }
}
