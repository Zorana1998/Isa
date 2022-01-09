using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaProject.Models.Entities.Users
{
    public class ShipAppointment
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [ForeignKey("AppUser")]
        public string OwnerID { get; set; }

        [ForeignKey("AppUser")]
        public string UserID { get; set; }

        [ForeignKey("Ship")]
        public long ShipID { get; set; }

        public DateTime Start { get; set; }
        public int DurationDays { get; set; }

        public int MaxNumberOfPeople { get; set; }

        public List<ShipTag> Tags { get; set; }

        public double Price { get; set; }

        public bool isScheduled { get; set; }
    }
}
