using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HynEcom.IdentityServer.EntityFrameworkCore.Entities
{
    public class Role
    {
        /// <summary>
        /// get or set Id
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// get or set Name
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// get or set Description
        /// </summary>
        public required string Description { get; set; }

        /// <summary>
        /// get or set IsDefault
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// get or set IsStatic
        /// </summary>
        [DefaultValue(false)]
        public bool IsStatic { get; set; }

        /// <summary>
        /// get or set IsPublic
        /// </summary>
        public bool IsPublic { get; set; }

        /// <summary>
        /// get or set IsDeleted
        /// </summary>
        public bool IsDeleted { get; set; } = false;
    }
}
