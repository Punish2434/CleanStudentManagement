using System;
using CleanStudentManagement.Data.Entities;

namespace CleanStudentManagement.Models
{
    public class CreateStudentViewModel
    {
        public required string Name { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }


        public Student ConvertToModel(CreateStudentViewModel vm)
        {
            return new Student
            {
                Name = vm.Name,
                UserName = vm.UserName,
                Password = vm.Password,

            };
        }


    }
}

