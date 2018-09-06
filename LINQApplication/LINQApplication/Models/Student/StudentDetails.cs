using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQApplication.Models.Student
{
    public class StudentDetails
    {
        public int studentID { get; set; }
        public string studentName { get; set; }
        public string studentClass { get; set; }
        public string studentRollNo { get; set; }
        public int studentAge { get; set; }
        public int studentFees { get; set; }
        public DateTime transactionDate { get; set; }
    }
}
