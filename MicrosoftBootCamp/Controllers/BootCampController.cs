using Microsoft.AspNetCore.Mvc;
using MicrosoftBootCamp.DataLayer;
using MicrosoftBootCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftBootCamp.Controllers
{
    public class BootCampController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        [Route("/BootCamp/AddStudent")]
        public IActionResult NewStudent(Student student)
        {
            StudentData.Add(student);
            return Redirect("/BootCamp/StudentInfo");
        }
        public IActionResult StudentInfo()
        {
            ViewBag.students = StudentData.GetAll();
            return View();
        }
    }
}
