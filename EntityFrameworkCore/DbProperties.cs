namespace HynEcom.IdentityServer.EntityFrameworkCore
{
    public static class DbProperties
    {
        public static string DbTablePrefix { get; set; } = "";

        public static string? DbSchema { get; set; } = null;

        public static string DbSchemaIdentity { get; set; } = "identity";
    }
}
