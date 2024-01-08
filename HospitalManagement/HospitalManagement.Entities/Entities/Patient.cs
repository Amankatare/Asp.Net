using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagement.Entities.Entities
{
    public class Patient : BaseEntity
    {
        [ForeignKey("AppointmentId")]
        public int AppointmentId { get; set; }

        public Appointment Appointment { get; set; }
    }
}