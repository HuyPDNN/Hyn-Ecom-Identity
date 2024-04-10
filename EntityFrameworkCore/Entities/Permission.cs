using System.ComponentModel.DataAnnotations;

namespace HynEcom.IdentityServer.EntityFrameworkCore.Entities
{
    public class Permission
    {
        /// <summary>
        /// get or set Id permission
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// get or set Name permission
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// get or set ProviderName permission
        /// </summary>
        public required string ProviderName { get; set; }

        /// <summary>
        ///  get or set ProviderKey permission
        /// </summary>
        public required string ProviderKey { get; set; }

        /// <summary>
        /// get or set IsDeleted permission
        /// </summary>
        public bool IsDeleted { get; set; } = false;
    }
}
