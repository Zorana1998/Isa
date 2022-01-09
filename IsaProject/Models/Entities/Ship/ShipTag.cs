using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaProject.Models.Entities
{
    public class ShipTag
    {
        [Key]
        [Required]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey("ShipAppointment")]
        public long ShipAppointmentID { get; set; }

        public bool IsChoosen { get; set; }

    }
}