using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaProject.Models.Entities
{
    public class Appointment
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [ForeignKey("AppUser")]
        public string OwnerID { get; set; }

        [ForeignKey("Entity")]
        public long EntityID { get; set; }

        public DateTime Start { get; set; }
        public int DurationDays { get; set; }

        public int MaxNumberOfPeople { get; set; }

        public List<Tag> Tags { get; set; }

        public double Price { get; set; }

        public List<AppointmentTag> appointmentTags { get; set; }

        

        public Appointment(string ownerId,long entityId, DateTime dateTime, int duration, int numberOfGuest, int numberOfDays, double price)
        {
            OwnerID = ownerId;
            EntityID = entityId;
            Start = dateTime;
            DurationDays = numberOfDays;
            MaxNumberOfPeople = numberOfGuest;
            Price = price;
            DurationDays = duration;
        }



        public Appointment()
        {

        }

    }
}
