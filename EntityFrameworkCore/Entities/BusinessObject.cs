using System.ComponentModel.DataAnnotations;

namespace HynEcom.IdentityServer.EntityFrameworkCore.Entities
{
    public class BusinessObject
    {
        /// <summary>
        /// Get or set Id
        /// </summary>
        [Key]
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
        [StringLength(50)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public required string Email { get; set; } = string.Empty;


        /// <summary>
        /// Get or set Phone
        /// </summary>
        [StringLength(30)]
        public required string Phone { get; set; } = string.Empty;

        /// <summary>
        /// Get or set Address
        /// </summary>
        [StringLength(500)]
        public required string Address { get; set; } = string.Empty;

        /// <summary>
        /// Get or set Description
        /// </summary>
        [StringLength(500)]
        public string? Description { get; set; } = null;

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
