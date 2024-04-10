namespace HynEcom.IdentityServer.Models
{

    public class UserRoleRequest
    {
        public Guid Id { get; set; }
        /// <summary>
        /// get or set UserId user role
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// get or set RoleId user role
        /// </summary>
        public Guid RoleId { get; set; }

        public required UserRequest UserRequest { get; set; }

        public required RoleRequest RoleRequest { get; set; }
    }
}
