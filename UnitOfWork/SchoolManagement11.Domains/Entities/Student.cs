namespace SchoolManagement11.Domains.Entities
{
    public class Student
    { 
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; }

        public string Phone { get; set; }

      //  public StudentActivity StudentActivity { get; set; }


      //  public Teacher Teacher { get; set; }
    }
}
