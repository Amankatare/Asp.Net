using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendBazar.Entities.Dtos
{
    public class RegisterToLoginDto
    {

        [Required]
        [DisplayName("UserName")]
        [EmailAddress]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Email")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DisplayName("ConfirmPassword")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public List<string> UserRoles { get; set; }

    }
}
