using System.Collections.Generic;
using System.Linq;
using LINQApplication.Data;
using LINQApplication.Models.Student;
using Microsoft.AspNetCore.Mvc;

namespace LINQApplication.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            StudentData studentData = new StudentData();
            List<Student> studentsList = studentData.GetStudentsList();
            List<Fee> studentsFees = FeeData.GetFeesList();
            StudentDetailsList studentDetailsList = new StudentDetailsList();
            studentDetailsList.studentList = (from student in studentsList
                                                   join studentFee in studentsFees 
                                                   on student.studentID equals studentFee.studentID
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

            return View(studentDetailsList);
        }

        [HttpPost]
        public IActionResult SearchById(SearchProperties searchProperties)
        {
            StudentData studentData = new StudentData();
            var students = studentData.GetStudents(searchProperties);

            if (students.Any())
            {
                return PartialView("_StudentListPartial", students);
            }
            else
            {
                return NotFound();
            }
        }
    }
}