using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaProject.Models.Entities
{
    public class AppointmentTag
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [ForeignKey("Appointment")]
        public long AppointmentID { get; set; }

        [ForeignKey("Tag")]
        public long TagId { get; set; }


    }
}
