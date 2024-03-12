using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanStudentManagement.BLL.Services;
using CleanStudentManagement.Data;
using CleanStudentManagement.Models;
using CleanStudentManagement.UI.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanStudentManagement.UI.Controllers
{
    [RoleAuthorize(2)]
    public class ExamsController : Controller
    {
        private readonly IGroupService _groupService;
        private readonly IExamService _examService;
        private readonly ApplicationDbContext _context;

        public ExamsController(IGroupService groupService, IExamService examService, ApplicationDbContext context)
        {
            _groupService = groupService;
            _examService = examService;
            _context = context;
        }

        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {

            return View(_examService.GetAll(pageNumber, pageSize));
        }
        [HttpGet]
        public IActionResult Create()
        {
            var groups = _groupService.GetAllGroups();
            ViewBag.AllGroups = new SelectList(groups, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateExamsViewModel vm)
        {
            _examService.AddExam(vm);
            return RedirectToAction("Index");
        }


    }
}

