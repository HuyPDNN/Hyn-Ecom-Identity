using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HynEcom.IdentityServer.EntityFrameworkCore.Entities
{
    public class UserRole
    {
        /// <summary>
        /// get or set Id
        /// </summary>
        [NotMapped]
        public Guid Id { get; set; }

        /// <summary>
        /// get or set UserId
        /// </summary>
        [Key]
        public Guid UserId { get; set; }

        /// <summary>
        /// get or set RoleId
        /// </summary>
        [Key]
        public Guid RoleId { get; set; }

        /// <summary>
        /// get or set IsDeleted
        /// </summary>
        public bool IsDeleted { get; set; } = false;


        [ForeignKey("UserId")]
        public required User User { get; set; }

        [ForeignKey("RoleId")]
        public required Role Role { get; set; }
    }
}
