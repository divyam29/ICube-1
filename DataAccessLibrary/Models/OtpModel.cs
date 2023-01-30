using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class OtpModel
    {
        public DateTime InDate { get; set; }
        public int OTP { get; set; }
        public string UserId { get; set; }
    }
}
