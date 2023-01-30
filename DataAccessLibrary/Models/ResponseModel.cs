using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class ResponseModel
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public int Issue_Id { get; set; }
        public int Amt { get; set; }
        public DateTime SubmitDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Prop_Tech { get; set; }
        public string Deli { get; set; }
        public string Amt_Bifur { get; set; }
        public int trl { get; set; }




        public int is_approved { get; set; }
        public int dhead { get; set; }
        public int dbody { get; set; }
        public int dpt { get; set; }
        public int ddeli { get; set; }
        public int damt { get; set; }
        public int dtrl { get; set; }
        public int damtb { get; set; }
        public int dcontinfo { get; set; }

    }
}
