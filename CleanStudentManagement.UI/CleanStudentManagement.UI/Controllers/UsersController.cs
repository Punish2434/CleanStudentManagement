using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanStudentManagement.BLL.Services;
using CleanStudentManagement.Data;
using CleanStudentManagement.Models;
using CleanStudentManagement.UI.Filters;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanStudentManagement.UI.Controllers
{
    //Filters :  Timinging, 
   [RoleAuthorize(1)]
    public class UsersController : Controller
    {
        private IAccountService _accountService;
        private readonly ApplicationDbContext _context;

        public UsersController(IAccountService accountService, ApplicationDbContext context)
        {
            _accountService = accountService;
            _context = context;
        }

        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            return View(_accountService.GetAllTeacher(pageNumber, pageSize));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserViewModel vm)
        {
            bool success = _accountService.AddTeacher(vm);
            if (success)
            {
                return RedirectToAction("Index");
            }
            return View(vm);

        }

    }
}

