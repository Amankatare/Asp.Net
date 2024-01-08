using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Entities.Entities
{
    public class Doctor : BaseEntity 
    {

        [ForeignKey("PatientId")]
        public int PatientId { get; set; }

        public Patient Patient { get; set; }

    }

}
