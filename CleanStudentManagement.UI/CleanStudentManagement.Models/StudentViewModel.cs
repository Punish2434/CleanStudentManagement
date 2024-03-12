using System;
using CleanStudentManagement.Data.Entities;

namespace CleanStudentManagement.Models
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string UserName { get; set; }
        public string? Contact { get; set; }

        public StudentViewModel(Student student)
        {
            StudentId = student.Id;
            StudentName = student.Name;
            UserName = student.UserName;
            Contact = student.Contact;

        }

    }
}

