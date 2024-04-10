namespace HynEcom.IdentityServer.Models
{
    public class UserRoleResponse
    {
        /// <summary>
        /// get or set UserId user role
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// get or set RoleId user role
        /// </summary>
        public Guid RoleId { get; set; }


        public required UserResponse User { get; set; }

        public required RoleResponse Role { get; set; }
    }
}
