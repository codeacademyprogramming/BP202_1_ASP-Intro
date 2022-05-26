using FirstWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstWeb.Controllers
{
    public class ExamController : Controller
    {
        private List<Exam> _exams;
        public ExamController()
        {
            _exams = new List<Exam>
            {
                new Exam(30,"Hikmet Abbasov",45),
                new Exam(35,"Hikmet Abbasova",88),
            };
        }
        public ActionResult Result(int studentId,int year)
        {
            return Content(studentId.ToString()+" - "+year.ToString());
            //return View();
        }

        public ActionResult Detail(int id)
        {
            Exam exam = _exams.Find(x => x.Id == id);

            TempData["ExamId"] = id;
            ViewData["ExamId"] = id;
            ViewBag.ExamId = id;
            ViewBag.StudentName = exam.StudentFullName;

            return View();
        }


    }
}
