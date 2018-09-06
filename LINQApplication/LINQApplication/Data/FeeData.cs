using LINQApplication.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQApplication.Data
{
    public class FeeData
    {
        public static List<Fee> GetFeesList()
        {
            return new List<Fee>
            {
                new Fee
                {
                    studentID=1,
                    studentFee=10000,
                    transactionDate=new DateTime(2018,5,1)
                },
                new Fee
                {
                    studentID=2,
                    studentFee=1000,
                    transactionDate=new DateTime(2018,4,1)
                },
                new Fee
                {
                    studentID=3,
                    studentFee=2000,
                    transactionDate=new DateTime(2018,3,1)
                },
                new Fee
                {
                    studentID=4,
                    studentFee=3000,
                    transactionDate=new DateTime(2017,6,1)
                },
                new Fee
                {
                    studentID=5,
                    studentFee=2000,
                    transactionDate=new DateTime(2017,8,1)
                },
                new Fee
                {
                    studentID=6,
                    studentFee=5000,
                    transactionDate=new DateTime(2017,3,1)
                },
                new Fee
                {
                    studentID=7,
                    studentFee=6000,
                    transactionDate=new DateTime(2016,5,1)
                },
                new Fee
                {
                    studentID=8,
                    studentFee=2000,
                    transactionDate=new DateTime(2018,1,1)
                }
            };
        }
    }
}
