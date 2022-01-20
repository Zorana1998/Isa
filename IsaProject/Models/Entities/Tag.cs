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

        public double Price { get; set; }

        public List<AppointmentTag> appointmentTags;

        public Tag()
        {
        }

        public Tag(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Tag(string name, double price)
        {
            
            Name = name;
            Price = price;
        }

    }
}
