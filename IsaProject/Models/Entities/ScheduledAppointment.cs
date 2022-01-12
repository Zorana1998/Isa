using IsaProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaProject.Models
{
    public class ScheduledAppointment
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [ForeignKey("AppUser")]
        public string UserID { get; set; }

        [ForeignKey("Entity")]
        public long EntityID { get; set; }

        public DateTime Start { get; set; }
        public int Duration { get; set; }

        public int NumberOfPeople { get; set; }

        public double Price { get; set; }

        public bool IsActive { get; set; }

        public List<AppointmentTag> appointmentTags { get; set; }

        public ScheduledAppointment(string userID, long entityId, DateTime dateTime, int numberOfGuest, int numberOfDays, double price, bool isActive)
        {
            UserID = userID;
            EntityID = entityId;
            Start = dateTime;
            Duration = numberOfDays;
            NumberOfPeople = numberOfGuest;
            Price = price;
            IsActive = isActive;
        }

        public ScheduledAppointment()
        {
            
        }
    }
}
