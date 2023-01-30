using System.ComponentModel.DataAnnotations;

namespace Dapper1.Models
{
    public class UserDisplayModel
    {
        [Required]
        public string OrgName { get; set; }
        [Required]
        public string OrgAddress { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public string desig { get; set; }
    }
}
