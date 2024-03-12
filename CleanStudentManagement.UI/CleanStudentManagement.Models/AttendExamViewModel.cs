using System;
namespace CleanStudentManagement.Models
{
    public class AttendExamViewModel
    {
        public int StudentId { get; set; }
        public string ExamName { get; set; }
        public List<QnAsViewModel> QnAsList { get; set; }
        public string Message { get; set; }
      

    }
}

