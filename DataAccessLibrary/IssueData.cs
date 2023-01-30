using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{

    public class IssueData : IIssueData
    {

        private readonly ISqlDataAccess _Issuedb;

        public IssueData(ISqlDataAccess db)
        {
            _Issuedb = db;
        }

        public Task<List<IssueModel>> GetIssues()
        {
            string sql = "select * from dbo.Issues";

            return _Issuedb.LoadData<IssueModel, dynamic>(sql, new { });
        }

        public Task<List<IssueModel>> GetIssue(int id)
        {
            string sql = "select * from dbo.Issues where id = '" + id + "'";

            return _Issuedb.LoadData<IssueModel, dynamic>(sql, new { });
        }

        public Task UpdateIssue(int id, IssueModel Issue)
        {
            string sql = "UPDATE dbo.Issues SET Heading = '" + Issue.Heading + "', Body = '" + Issue.Body + "', UpdateDate = @UpdateDate WHERE id = '" + id + "';";

            return _Issuedb.SaveData(sql, Issue);
        }

        public Task InsertIssue(IssueModel Issue)
        {
            string sql = @"insert into dbo.Issues (userid, Heading, Body, SubmitDate, UpdateDate)
                           values (@UserId, @Heading, @Body, @SubmitDate, @UpdateDate);";

            return _Issuedb.SaveData(sql, Issue);
        }
		public Task<List<IssueModel>> GetIndIssues(int id)
		{
			string sql = "select * from dbo.Issues where userid = '" + id + "'";
			return _Issuedb.LoadData<IssueModel, dynamic>(sql, new { });
		}

	}


}
