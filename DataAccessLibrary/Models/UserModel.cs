using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string OrgName { get; set; }
        public string OrgAddress { get; set; }
        public string desig { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int is_expert { get; set; }
        public int is_industry { get; set; }
        public string fileName { get; set; }
        public int is_admin { get; set; }
    }
}
