using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanStudentManagement.BLL.Services;
using CleanStudentManagement.Data;
using CleanStudentManagement.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanStudentManagement.UI.Controllers
{
    public class GroupsController : Controller
    {
        private IGroupService _groupService;
        private IStudentService _studentService;
        private readonly ApplicationDbContext _context;

        public GroupsController(IGroupService groupService, IStudentService studentService, ApplicationDbContext context)
        {
            _groupService = groupService;
            _studentService = studentService;
            _context = context;
        }

        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            return View(_groupService.GetAll(pageNumber, pageSize));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(GroupViewModel viewModel)
        {
            var vm = _groupService.Addgroup(viewModel);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            GroupStudentViewModel vm = new GroupStudentViewModel();
            var group = _groupService.GetGroup(id);
            var students = _studentService.GetAll();
            vm.GroupId = group.Id;
            foreach (var student in students)
            {
                vm.StudentList.Add(new CheckBoxTable
                {
                    Id = student.Id,
                    Name = student.Name,
                    IsChecked = student.GroupsId == null? false: true

                });
            }
            return View(vm);


        }
        [HttpPost]
        public IActionResult Details(GroupStudentViewModel viewModel)
        {
            bool result = _studentService.SetGroupIdToStudent(viewModel);
            if (result)
            {
                return RedirectToAction("Index");
            }
            return View(viewModel);

        }
    }
}

