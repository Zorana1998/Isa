using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaProject.Models.Entities
{
    public class Tag
    {
        [Key]
        [Required]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }

        public List<AppointmentTag> appointmentTags;

        

    }
}
