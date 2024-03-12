using System;
using CleanStudentManagement.Models;

namespace CleanStudentManagement.BLL.Services
{
    public interface IExamService
    {
        PagedResult<ExamViewModel> GetAll(int pageNumber, int pageSize);
        void AddExam(CreateExamsViewModel viewModel);
        IEnumerable<ExamViewModel> GetAllExams();

    }
}

