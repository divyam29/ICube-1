using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IOTPData
    {
        Task<List<OtpModel>> GetOtp();
        Task InsertOtp(OtpModel person);
    }
}