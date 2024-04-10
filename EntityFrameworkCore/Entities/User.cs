using System.ComponentModel.DataAnnotations;

namespace HynEcom.IdentityServer.EntityFrameworkCore.Entities
{
    public class User
    {
        /// <summary>
        /// get or set Id
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// get or set UserName
        /// </summary>
        public required string UserName { get; set; }

        /// <summary>
        /// get or set Password
        /// </summary>
        public required string Password { get; set; }

        /// <summary>
        /// get or set PasswordHash
        /// </summary>
        public string? PasswordHash { get; set; }

        /// <summary>
        /// get or set IsDeleted
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        public List<UserRole>? UserRoles { get; set; }
    }
}
