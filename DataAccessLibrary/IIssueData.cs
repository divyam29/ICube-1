using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IIssueData
    {
        Task<List<IssueModel>> GetIssues();
        Task<List<IssueModel>> GetIssue(int id);
        Task UpdateIssue(int id, IssueModel Issue);
        Task InsertIssue(IssueModel Issue);
        Task<List<IssueModel>> GetIndIssues(int id);

	}
}