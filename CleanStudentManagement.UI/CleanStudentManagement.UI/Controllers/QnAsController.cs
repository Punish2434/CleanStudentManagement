using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanStudentManagement.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using CleanStudentManagement.Models;
using CleanStudentManagement.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanStudentManagement.UI.Controllers
{
    public class QnAsController : Controller
    {
        private IExamService _examService;
        private IQnAsService _iqnAsService;
        private readonly ApplicationDbContext _context;

        public QnAsController(IExamService examService, IQnAsService iqnAsService, ApplicationDbContext context)
        {
            _examService = examService;
            _iqnAsService = iqnAsService;
            _context = context;
        }

        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            var qnAs = _iqnAsService.GetAll(pageNumber, pageSize);
            return View(qnAs);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var exams = _examService.GetAllExams();
            ViewBag.examsList = new SelectList(exams, "Id", "Title");
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateQnAsViewModel viewModel)
        {
            _iqnAsService.AddQnAs(viewModel);
            return RedirectToAction("Index");
        }

    }
}

