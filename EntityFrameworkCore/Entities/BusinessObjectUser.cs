using System.ComponentModel.DataAnnotations;

namespace HynEcom.IdentityServer.EntityFrameworkCore.Entities
{
    public class BusinessObjectUser
    {
        /// <summary>
        /// Get or set Id
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Get or set UserId
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Get or set BusinessObjectId
        /// </summary>
        public Guid BusinessObjectId { get; set; }

        /// <summary>
        /// Get or set IsActive
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Get or set IsDeleted
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// Get or set BusinessObject
        /// </summary>
        public required BusinessObject BusinessObject { get; set; }

        /// <summary>
        /// Get or set User
        /// </summary>
        public required User User { get; set; }
    }
}
