using Dapper;
using HynEcom.IdentityServer.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HynEcom.IdentityServer.Models.BaseService
{
    public class BaseService : IBaseService
    {
        private readonly HynEcomIdentityDbContext _dbContext;

        public BaseService(HynEcomIdentityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Multiple soft deleted data by id - Change IsDeleted = true
        /// </summary>
        /// <param name="listId"></param>
        /// <param name="dbSchema"></param>
        /// <param name="tblName"></param>
        /// <returns>true :: success | false :: fail</returns>
        public async Task<bool> MultipleSoftDeteledAsync(List<Guid> listId, string dbSchema, string tblName)
        {
            try
            {
                var idConvertString = string.Join(",", listId);

                var _connection = _dbContext.Database.GetDbConnection();

                _connection.Open();
                await _connection.QueryAsync(
                        Enum.Function.Base.fn_soft_delete_multiple_dynamic_table,
                        param: new
                        {
                            db_schema = dbSchema,
                            tbl_name = tblName,
                            ids = idConvertString,
                        },
                        commandType: CommandType.Text
                    );
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Multiple hard deleted data by id - delete from database
        /// </summary>
        /// <param name="listId"></param>
        /// <param name="dbSchema"></param>
        /// <param name="tblName"></param>
        /// <returns>true :: success | false :: fail</returns>
        public async Task<bool> MultipleHardDeteledAsync(List<Guid> listId, string dbSchema, string tblName)
        {
            try
            {
                var idConvertString = string.Join(",", listId);

                var _connection = _dbContext.Database.GetDbConnection();

                await _connection.QueryAsync(
                        Enum.Function.Base.fn_hard_delete_multiple_dynamic_table,
                        param: new
                        {
                            db_schema = dbSchema,
                            tbl_name = tblName,
                            ids = idConvertString,
                        },
                        commandType: CommandType.Text
                    );
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
