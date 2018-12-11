using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentList.Models;

namespace StudentList.Controllers
{
    public class StudentController : Controller
    {
        private MyDbContext context;

        public StudentController(MyDbContext context)
        {
            this.context = context;
        }

        public IActionResult StudentList()
        {
            var studentList = context.Students.ToList();
            return View(studentList);
        }

        public JsonResult SearchForStudent(DateTime searchKeyword)
        {

            var studentList = context.Students.Where(x => x.DateOfBirth == searchKeyword).ToList();
            //var jsonStudents = Json(studentList.Where(x =>
            //{
            //    x.DateOfBirth == searchKeyword;
            //}));
            return Json(studentList);
        }

        public JsonResult SearchForName(string search, DateTime searchDate)
        {

            var studentList = context.Students.Where(x => x.Name.Contains(search) || x.FatherName.Contains(search) || x.Address.Contains(search) || x.Class.Contains(search) || x.DateOfBirth == searchDate).ToList();

            return Json(studentList);
        }



    }
}