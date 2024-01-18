using System;
namespace CleanStudentManagement.Models
{
    public class GroupStudentViewModel
    {
        public int GroupId { get; set; }
        public List<CheckBoxTable> StudentList { get; set; } = new();

    }
    
}

