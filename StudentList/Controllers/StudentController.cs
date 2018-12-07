﻿using System;
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

    }
}