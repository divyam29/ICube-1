using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IUserData
    {
        Task<List<UserModel>> GetUser(int id);
        Task<List<UserModel>> GetUserEmail(string email);
        Task InsertUser(UserModel person);
    }
}