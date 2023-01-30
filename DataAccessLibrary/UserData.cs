using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _Userdb;

        public UserData(ISqlDataAccess db)
        {
            _Userdb = db;
        }

        public Task<List<UserModel>> GetUser(int id)
        {
            string sql = "select * from dbo.Users where id = '" + id + "'";
            return _Userdb.LoadData<UserModel, dynamic> (sql, new { });
        }

        public Task<List<UserModel>> GetUserEmail(string email)
        {
            string sql = "select * from dbo.Users where UserName = '" + email + "'";
            return _Userdb.LoadData<UserModel, dynamic>(sql, new { });
        }

        public Task InsertUser(UserModel person)
        {
            string sql = @"insert into dbo.Users (UserName, Orgname, OrgAddress, desig, Phone, Password, is_expert, is_industry, is_admin)
                           values (@UserName, @OrgName, @OrgAddress, @desig, @Phone, @Password, @IsExpert, @IsIndustry, @IsAdmin);";

            return _Userdb.SaveData(sql, person);
        }
    }
}
