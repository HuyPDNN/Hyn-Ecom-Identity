namespace HynEcom.IdentityServer.Models.BaseService
{
    public interface IBaseService
    {
        Task<bool> MultipleSoftDeteledAsync(List<Guid> listId, string dbSchema, string tblName);

        Task<bool> MultipleHardDeteledAsync(List<Guid> listId, string dbSchema, string tblName);
    }
}
