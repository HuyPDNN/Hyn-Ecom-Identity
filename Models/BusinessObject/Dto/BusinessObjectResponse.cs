using System.ComponentModel.DataAnnotations;

namespace HynEcom.IdentityServer.Models
{
    public class BusinessObjectResponse
    {
        /// <summary>
        /// Get or set Id
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Get or set Code
        /// </summary>
        [StringLength(30)]
        public required string Code { get; set; } = string.Empty;

        /// <summary>
        /// Get or set Name
        /// </summary>
        public required string Name { get; set; } = string.Empty;

        /// <summary>
        /// Get or set DateOfBirth
        /// </summary>
        public DateTime? DateOfBirth { get; set; } = null;

        /// <summary>
        /// Get or set Email
        /// </summary>
        public required string Email { get; set; } = string.Empty;

        /// <summary>
        /// Get or set Phone
        /// </summary>
        public required string Phone { get; set; } = string.Empty;

        /// <summary>
        /// Get or set Address
        /// </summary>
        public required string Address { get; set; } = string.Empty;

        /// <summary>
        /// Get or set Description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Get or set IsActive
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Get or set IsDeleted
        /// </summary>
        public bool IsDeleted { get; set; } = false;
    }
}
