namespace HynEcom.IdentityServer.Models
{
    public class PermissionRequest
    {
        /// <summary>
        /// get or set Id permission
        /// </summary>
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
    }
}
