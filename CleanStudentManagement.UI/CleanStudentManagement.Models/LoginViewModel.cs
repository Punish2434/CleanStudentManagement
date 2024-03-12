using System;
using System.ComponentModel.DataAnnotations;

namespace CleanStudentManagement.Models
{
    public class LoginViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "User Name field is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "User Password field is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "User Role field is Required")]
        public int Role { get; set; }

    }
}

