using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class OTPData : IOTPData
    {
        private readonly ISqlDataAccess _Otpdb;

        public OTPData(ISqlDataAccess db)
        {
            _Otpdb = db;
        }


        public Task<List<OtpModel>> GetOtp()
        {
            string sql = "select * from dbo.otp";

            return _Otpdb.LoadData<OtpModel, dynamic>(sql, new { });
        }

        public Task InsertOtp(OtpModel person)
        {
            string sql = @"insert into dbo.otp (intime, otp, userid)
                           values (@InDate, @OTP, @UserId);";

            return _Otpdb.SaveData(sql, person);
        }

    }
}
