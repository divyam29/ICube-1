using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IResponseData
    {
        Task<List<ResponseModel>> GetResponse(int id);
        Task<List<ResponseModel>> GetResponses();
        Task UpdateResponse(int id, ResponseModel res);
        Task AddResponse(ResponseModel res);
    }
}