using HynEcom.IdentityServer.EntityFrameworkCore.Entities;

namespace HynEcom.IdentityServer.Repositories
{
    public interface IBusinessObjectDapperRepository
    {
        Task<List<BusinessObject>> GetAllAsync(string keyWord, int skipCount, int maxResultCount);
    }
}
