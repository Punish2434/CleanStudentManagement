using System;
using CleanStudentManagement.Data.Entities;

namespace CleanStudentManagement.Models
{
    public class StudentsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public StudentsViewModel(Student student)
        {
            Id = student.Id;
            Name = student.Name;

        }



    }
    public class CheckBoxTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsChecked { get; set; }
    }

}

