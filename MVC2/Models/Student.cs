using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MVC2.Models
{
    public class Student
    {
        private readonly ModelStateDictionary ModelState;

        [Key]
        [Column("RollNo")]
        public int RollNo { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="The Name is Required!!!!!!!!!!!!!!")]
        [MaxLength(100)]
        [MinLength(4)]
        public string Name { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "The EmailAddress is Required!!!!!!!!!!!!!!")]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "The Phone is Required!!!!!!!!!!!!!!")]
        [Phone]
        public string PhoneNumber { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "The Password is Required!!!!!!!!!!!!!!")]
        [RegularExpression("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[\\W_])[A-Za-z\\d\\W_]{8,}$")]
        public string Password { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "The PasswordConfirmation is Required!!!!!!!!!!!!!!")]
        [Compare("Password")]
        public string PasswordConfirmation { get; set; }

        public string successMessage = "";
        public string errorMessage = "";
        public string updateMessage = "";
        public string errorMessage1 = "";

        public void onPost()
        {
            if (!ModelState.IsValid)
            {
                errorMessage = "Data Validation failed!!!!!!!!!!";
                return;
            }
            successMessage = "Student Creation Successfull";

            Name = "";
            Email = "";
            PhoneNumber = "";
            Password = "";
            PasswordConfirmation = "";

            ModelState.Clear();
        }

        public void onPut()
        {
            if (!ModelState.IsValid)
            {
                errorMessage1 = "Something Went Wrong!!!!!!!!!!";
                return;
            }
            updateMessage = "Student Updation Successfull";

            Name = "";
            Email = "";
            PhoneNumber = "";
            Password = "";
            PasswordConfirmation = "";

            ModelState.Clear();
        }
    }
}
