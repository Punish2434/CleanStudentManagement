using System;
using CleanStudentManagement.Models;

namespace CleanStudentManagement.BLL.Services
{
    public interface IAccountService
    {
        bool AddTeacher(UserViewModel vm);
        LoginViewModel Login(LoginViewModel loginViewModel);
        PagedResult<TeacherViewModel> GetAllTeacher(int pageNumber, int PageSize);

    }
}

