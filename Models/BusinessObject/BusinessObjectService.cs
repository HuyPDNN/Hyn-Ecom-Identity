using AutoMapper;
using Dapper;
using HynEcom.IdentityServer.EntityFrameworkCore;
using HynEcom.IdentityServer.Models.BaseService;
using Microsoft.EntityFrameworkCore;
using System.Data;
using static Dapper.SqlMapper;

namespace HynEcom.IdentityServer.Models
{
    public class BusinessObjectService : IBusinessObjectService
    {
        private readonly IMapper _mapper;
        private readonly HynEcomIdentityDbContext _dbContext;
        private readonly string _tableName;
        private readonly IBaseService _baseService;

        public BusinessObjectService(
            IMapper mapper,
            HynEcomIdentityDbContext dbContext,
            IBaseService baseService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _tableName = "BusinessObjects";
            _baseService = baseService;
        }

        public async Task<BusinessObjectResponse> CreateAsync(BusinessObjectRequest request)
        {
            try
            {
                var _connection = _dbContext.Database.GetDbConnection();

                var result = await _connection.QueryAsync(
                        "SELECT * FROM fn_insert_business_object(@_id, @_code, @_name, @_date_of_birth, @_email, @_phone, @_address, @_description, @_is_active, @_is_deleted)",
                        param: new
                        {
                            _id = Guid.NewGuid(),
                            _code = request.Code,
                            _name = request.Name,
                            _date_of_birth = request.DateOfBirth,
                            _email = request.Email,  
                            _phone = request.Phone,
                            _address = request.Address,
                            _description = request.Description,
                            _is_active = request.IsActive,
                            _is_deleted = request.IsDeleted,
                        },
                        commandType: CommandType.Text
                    );
                return _mapper.Map<List<BusinessObjectResponse>>(result.FirstOrDefault());
            }
            catch (Exception) { throw; }

            //try
            //{
            //    var result = await _dbContext.AddAsync(_mapper.Map<BusinessObject>(request));

            //    await _dbContext.SaveChangesAsync();

            //    return _mapper.Map<BusinessObjectResponse>(result.Entity);
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }

        public async Task<List<BusinessObjectResponse>> GetAllAsync(PagedResultRequest request)
        {
            try
            {
                var _connection = _dbContext.Database.GetDbConnection();

                var result = await _connection.QueryAsync(
                        Enum.Function.BusinessObject.fn_gets_business_object_for_pages,
                        param: new
                        {
                            keyword = request.KeyWord,
                            skipcount = request.SkipCount,
                            maxresultcount = request.MaxResultCount,
                        },
                        commandType: CommandType.Text
                    );
                return _mapper.Map<List<BusinessObjectResponse>>(result.ToList());
            }
            catch (Exception) { throw; }
        }

        public async Task<List<BusinessObjectResponse>> GetByIds(List<Guid> listId)
        {
            var idConvertString = string.Join(",", listId);
            var _connection = _dbContext.Database.GetDbConnection();

            var result = await _connection.QueryAsync(
                        Enum.Function.BusinessObject.fn_gets_business_object_by_ids,
                        param: new
                        {
                            ids = idConvertString,
                        },
                        commandType: CommandType.Text
                    );
            return _mapper.Map<List<BusinessObjectResponse>>(result.ToList());
        }
    }
}
