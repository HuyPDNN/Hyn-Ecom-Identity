using System.ComponentModel;

namespace HynEcom.IdentityServer.Models
{
    public class RoleResponse
    {
        /// <summary>
        /// get or set Id Role
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// get or set Name Role
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// get or set Description Role
        /// </summary>
        public required string Description { get; set; }

        /// <summary>
        /// get or set IsDefault Role
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// get or set IsStatic Role
        /// </summary>
        [DefaultValue(false)]
        public bool IsStatic { get; set; }

        /// <summary>
        /// get or set IsPublic Role
        /// </summary>
        public bool IsPublic { get; set; }
    }
}
