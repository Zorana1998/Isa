using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IsaProject.Models.Entities
{
    public abstract class Entity
    {
        [Key]
        [Required]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PromotionalDescription { get; set; }
        [Required]
        public double AverageScore { get; set; }
        public List<Image> Images { get; set; }
        public string Rules { get; set; }
        public List<Appointment> Appointments { get; set; }

        public string OwnerID { get; set; }

        public bool IsLogicalDelete { get; set; }
    }
}
