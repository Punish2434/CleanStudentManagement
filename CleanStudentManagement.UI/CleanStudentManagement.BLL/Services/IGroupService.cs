using System;
using CleanStudentManagement.Models;

namespace CleanStudentManagement.BLL.Services
{
    public interface IGroupService
    {
        PagedResult<GroupViewModel> GetAll(int pageNumber, int pageSize);
        IEnumerable<GroupViewModel> GetAllGroups();
        GroupViewModel GetGroup(int id);
        GroupViewModel Addgroup(GroupViewModel group);

    }
}

