using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class ResponseData : IResponseData
    {
        private readonly ISqlDataAccess _db;

        public ResponseData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ResponseModel>> GetResponses()
        {

            string sql = "select * from dbo.Response";
            return _db.LoadData<ResponseModel, dynamic>(sql, new { });

        }

        public Task<List<ResponseModel>> GetResponse(int id)
        {

            string sql = "select * from dbo.Response where id = '" + id + "' AND is_approved = 1";
            return _db.LoadData<ResponseModel, dynamic>(sql, new { });

        }

        public Task UpdateResponse(int id, ResponseModel res)
        {

            string sql = "UPDATE dbo.Response SET dhead = @dhead, dbody = @dbody, dpt = @dpt, ddeli = @ddeli, damt = @damt, damtb = @damtb, dtrl = @dtrl, is_approved = @is_approved, dcontinfo = @dcontinfo WHERE id = '" + id + "';";

            return _db.SaveData(sql, res);

        }

        public Task AddResponse(ResponseModel res)
        {

            string sql = "insert into dbo.Response (Heading, Body, issue_id, UpdateDate, SubmitDate, userid, prop_tech, deli, amt, amt_bifur, trl) values (@Heading, @Body, @Issue_Id, @SubmitDate, @UpdateDate, @UserId, @Prop_Tech, @deli, @BidAmt, @Amt_Bifur, @trl);";

            return _db.SaveData(sql, res);
        }
    }
}
