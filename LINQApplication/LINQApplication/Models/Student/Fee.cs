using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQApplication.Models.Student
{
    public class Fee
    {
        public int studentID { get; set; }
        public int studentFee { get; set; }
        public DateTime transactionDate { get; set; }
    }
}
