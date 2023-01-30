using System.ComponentModel.DataAnnotations;

namespace Dapper1.Models
{
    public class SubIssueModel
    {
        [Required]
        public string Heading { get; set; }
        [Required]
        public string IssueBody { get; set; }

    
    }
}
