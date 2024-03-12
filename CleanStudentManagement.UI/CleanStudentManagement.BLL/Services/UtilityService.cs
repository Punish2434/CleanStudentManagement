using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleanStudentManagement.BLL.Services
{
    public class UtilityService : IUtilityService
    {
        public Task DeleteImage(string ContainerName, string dbPath)
        {
            throw new NotImplementedException();
        }

        public Task<string> EditImage(string ContainerName, IFormFile file, string dbPath)
        {
            throw new NotImplementedException();
        }

        public Task<string> SaveImage(string ContainerName, IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}

