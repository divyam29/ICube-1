using System.ComponentModel.DataAnnotations;

namespace Dapper1.Models
{
    public class ResponseDisplayModel
    {
        [Required]
        public string Heading { get; set; }
        [Required]
        public string Body { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public int Issue_Id { get; set; }
        [Required]
        public int BidAmt { get; set; }
        public DateTime SubmitDate { get; set; }
        public DateTime UpdateDate { get; set; }
        [Required]
        public string Prop_Tech { get; set; }
        [Required]
        public string Deli { get; set; }
        [Required]
        public string Amt_Bifur { get; set; }
        public string trl { get; set; }

        public bool is_approved { get; set; }
        public bool dhead { get; set; }
        public bool dtrl { get; set; }
        public bool dbody { get; set; }
        public bool dpt { get; set; }
        public bool ddeli { get; set; }
        public bool damt { get; set; }
        public bool damtb { get; set; }
        public bool dcontinfo { get; set; }
    }
}
