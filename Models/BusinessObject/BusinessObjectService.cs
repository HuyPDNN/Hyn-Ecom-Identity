using AutoMapper;
using Dapper;
using HynEcom.IdentityServer.EntityFrameworkCore;
using HynEcom.IdentityServer.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using static Dapper.SqlMapper;

namespace HynEcom.IdentityServer.Models
{
    public class BusinessObjectService : IBusinessObjectService
    {
        private readonly IMapper _mapper;
        private readonly HynEcomIdentityDbContext _dbContext;
        public BusinessObjectService(
            IMapper mapper,
            HynEcomIdentityDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<BusinessObjectResponse> CreateAsync(BusinessObjectRequest request)
        {
            try
            {
                var result = await _dbContext.AddAsync(_mapper.Map<BusinessObject>(request));

                await _dbContext.SaveChangesAsync();

                return _mapper.Map<BusinessObjectResponse>(result.Entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<BusinessObjectResponse>> GetAllAsync(PagedResultRequest request)
        {
            try
            {
                var _connection = _dbContext.Database.GetDbConnection();

                var result = await _connection.QueryAsync<BusinessObject>(
                        "identity.fn_gets_business_object_for_pages",
                        param: new
                        {
                            key_word = request.KeyWord,
                            skip_count = request.SkipCount,
                            max_result_count = request.MaxResultCount,
                        },
                        commandType: CommandType.StoredProcedure
                    );
                var dataMap = _mapper.Map<List<BusinessObjectResponse>>(result.ToList());
                return dataMap;
            }
            catch (Exception) { throw; }
        }
    }
}
