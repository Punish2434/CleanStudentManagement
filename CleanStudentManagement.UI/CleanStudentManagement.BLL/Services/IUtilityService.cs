using System;
using Microsoft.AspNetCore.Http;

namespace CleanStudentManagement.BLL.Services
{
	public interface IUtilityService
    {
        Task<string> SaveImage(string ContainerName, IFormFile file);
        Task<string> EditImage(string ContainerName, IFormFile file, string dbPath);
        Task DeleteImage(string ContainerName, string dbPath);


    }
}

