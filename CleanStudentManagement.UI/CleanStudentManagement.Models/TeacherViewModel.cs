using System;
using CleanStudentManagement.Data.Entities;


namespace CleanStudentManagement.Models
{
    public class TeacherViewModel
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }

        public TeacherViewModel(Users user)
        {
            Name = user.Name;
            UserName = user.UserName;
            EnumRoles enumRole = (EnumRoles)user.Role;
            Role = enumRole.ToString();

        }




    }
}

