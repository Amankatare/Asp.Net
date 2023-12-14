using System.ComponentModel.DataAnnotations.Schema;
using Task.Repository.Interface;

namespace Task.Models.Domain
{
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }

        public string Code { get; set; }

        public string District { get; set; }
        public string State { get; set; }

        public string Country { get; set; }
        public string? FullAddress { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
