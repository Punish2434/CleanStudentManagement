using System;
using CleanStudentManagement.Models;

namespace CleanStudentManagement.BLL.Services
{
    public interface IQnAsService
    {
        void AddQnAs(CreateQnAsViewModel viewModel);
        PagedResult<QnAsViewModel> GetAll(int pageNumber, int pageSize);

        bool IsAttendExam(int ExamId, int StudentId);
        IEnumerable<QnAsViewModel> GetAllByExamId(int examId);
    }
}

