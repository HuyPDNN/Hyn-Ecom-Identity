namespace HynEcom.IdentityServer.Models
{
    public class PagedResultRequest
    {
        public string? KeyWord { get; set; }

        public int SkipCount { get; set; }

        public int MaxResultCount { get; set; }
    }
}
