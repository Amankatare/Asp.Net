using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TrendBazar.Entities.Dtos
{
    public class LoginDto
    {
        [Required]
        [DisplayName("UserName")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }



    }
}
