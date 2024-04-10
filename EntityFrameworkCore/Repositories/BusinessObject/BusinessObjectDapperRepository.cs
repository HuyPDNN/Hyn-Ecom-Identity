using Dapper;
using HynEcom.IdentityServer.EntityFrameworkCore.Entities;
using System.Data;
using System.Data.SqlClient;

namespace HynEcom.IdentityServer.Repositories
{
    public class BusinessObjectDapperRepository : IBusinessObjectDapperRepository
    {
        private readonly SqlConnection _connection;
        private readonly IConfiguration _configuration;
        public BusinessObjectDapperRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public async Task<List<BusinessObject>> GetAllAsync(string keyWord, int skipCount, int maxResultCount)
        {
            try
            {
                var result = await _connection.QueryAsync<BusinessObject>(
                        "identity.fn_gets_business_object_for_pages",
                        param: new
                        {
                            keyWord,
                            skipCount,
                            maxResultCount
                        },
                        commandType: CommandType.StoredProcedure
                    );
                return result.ToList();
            }
            catch (Exception) { throw; }
        }
    }
}
