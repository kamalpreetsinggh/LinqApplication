using LINQApplication.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQApplication.Data
{
    public class StudentData
    {
        public List<Student> GetStudentsList()
        {
            return new List<Student>
            {
                new Student
                {
                    studentID=1,
                    studentName="Kamalpreet Singh",
                    studentClass="12",
                    studentRollNo="1",
                    studentAge=23
                },
                 new Student
                {
                    studentID=2,
                    studentName="Jagmeet Singh",
                    studentClass="12",
                    studentRollNo="2",
                    studentAge=24
                },
                  new Student
                {
                    studentID=3,
                    studentName="Karan Breja",
                    studentClass="12",
                    studentRollNo="3",
                    studentAge=25
                },
                   new Student
                {
                    studentID=4,
                    studentName="Lakshay Chaudhary",
                    studentClass="11",
                    studentRollNo="1",
                    studentAge=26
                },
                    new Student
                {
                    studentID=5,
                    studentName="Hariom Sardana",
                    studentClass="11",
                    studentRollNo="2",
                    studentAge=21
                },
                     new Student
                {
                    studentID=6,
                    studentName="Aditya Khurana",
                    studentClass="11",
                    studentRollNo="3",
                    studentAge=22
                },
                      new Student
                {
                    studentID=7,
                    studentName="Kartik Sharma",
                    studentClass="10",
                    studentRollNo="1",
                    studentAge=23
                },
                       new Student
                {
                    studentID=8,
                    studentName="Sahil Goyal",
                    studentClass="10",
                    studentRollNo="2",
                    studentAge=24
                }
            };
        }

        public List<StudentDetails> GetStudents(SearchProperties searchProperties)
        {
            var studentsList = GetStudentsList();
            var studentsFees = FeeData.GetFeesList();
            var searchResult = (from student in studentsList
                                join studentFee in studentsFees
                                on student.studentID equals studentFee.studentID
                                where ((searchProperties.searchBy == "id" && (searchProperties.search == student.studentID.ToString() || searchProperties.search == null)) ||
                                (searchProperties.searchBy == "name" && (searchProperties.search == student.studentName || searchProperties.search == null)) ||
                                (searchProperties.searchBy == "class" && (searchProperties.search == student.studentClass || searchProperties.search == null))) &&
                                (searchProperties.min <= studentFee.studentFee && searchProperties.max >= studentFee.studentFee)
                                select new StudentDetails
                                {
                                    studentID = student.studentID,
                                    studentName = student.studentName,
                                    studentClass = student.studentClass,
                                    studentRollNo = student.studentRollNo,
                                    studentAge = student.studentAge,
                                    studentFees = studentFee.studentFee,
                                    transactionDate = studentFee.transactionDate
                                }).ToList();

            return OrderBy(searchResult, searchProperties.orderBy);
        }

        public List<StudentDetails> OrderBy(List<StudentDetails> studentDetailsList, string orderBy)
        {
            switch (orderBy)
            {
                case "id":
                    studentDetailsList = (from student in studentDetailsList
                                          orderby student.studentID
                                          select student).ToList();
                    break;
                case "name":
                    studentDetailsList = (from student in studentDetailsList
                                          orderby student.studentName
                                          select student).ToList();
                    break;
                case "class":
                    studentDetailsList = (from student in studentDetailsList
                                          orderby student.studentClass
                                          select student).ToList();
                    break;
            }

            return studentDetailsList;
        }
    }
}
