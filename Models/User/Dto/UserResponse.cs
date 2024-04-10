namespace HynEcom.IdentityServer.Models
{
    public class UserResponse
    {
        /// <summary>
        /// get or set Id of user
        /// </summary>

        public Guid Id { get; set; }

        /// <summary>
        /// get or set Name of user
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// get or set Email of user
        /// </summary>
        public required string Email { get; set; }

        /// <summary>
        /// get or set UserName of user
        /// </summary>
        public required string UserName { get; set; }

        /// <summary>
        /// get or set Password of user
        /// </summary>
        public required string Password { get; set; }

        /// <summary>
        /// get or set PasswordHash user
        /// </summary>
        public string? PasswordHash { get; set; }

        /// <summary>
        ///  get or set PhoneNumber user
        /// </summary>
        public string? PhoneNumber { get; set; }

        public List<BusinessObjectResponse>? UserRoles { get; set; }
    }
}
