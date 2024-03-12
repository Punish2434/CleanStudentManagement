﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using CleanStudentManagement.BLL.Services;
using CleanStudentManagement.Models;
using CleanStudentManagement.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanStudentManagement.UI.Controllers
{
    public class AccountsController : Controller
    {

        private readonly ApplicationDbContext _context;
        private IAccountService _accountService;

        public AccountsController(IAccountService accountService, ApplicationDbContext context)
        {
            _accountService = accountService;
            _context = context;
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

                LoginViewModel vm = _accountService.Login(model);
                if (vm != null)
                {
                    string sessionObj = JsonSerializer.Serialize(vm);
                    HttpContext.Session.SetString("loginDetails", sessionObj); //Session save

                    var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,model.UserName)
                };
                    var claimsIdentity = new ClaimsIdentity(claims,
                        CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme
                        , new ClaimsPrincipal(claimsIdentity));

                    return RedirectToUser(vm);
                }
            }

            return View(model);
        }

        private IActionResult RedirectToUser(LoginViewModel vm)
        {
            if (vm.Role == (int)EnumRoles.Admin)
            {
                return RedirectToAction("Index", "Users");
            }
            else if (vm.Role == (int)EnumRoles.Teacher)

            {
                return RedirectToAction("Index", "Exams");
            }
            else
            {
                return RedirectToAction("Profile", "Students");
            }

        }
    }
}

