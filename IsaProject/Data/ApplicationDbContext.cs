using IsaProject.Models;
using IsaProject.Models.DTO;
using IsaProject.Models.Entities;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using IsaProject.Models.Entities.Adventure;
using Isa.Models;

namespace IsaProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AppUser> tbAppUsers { get; set; }

        public DbSet<Entity> Entities { get; set; }

        public DbSet<Cottage> Cottages { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<AppointmentDTO> cottageAppointmentDTOs { get; set; }
        public DbSet<Ship> Ships { get; set; }

        public DbSet<ShipBooking> ShipBooking { get; set; }
        public DbSet<Adventure> Adventure { get; set; }
        public DbSet<IsaProject.Models.Entities.AppointmentTag> AppointmentTag { get; set; }

        public DbSet<IsaProject.Models.Entities.FastReservation> FastReservations { get; set; }

        public DbSet<IsaProject.Models.ScheduledAppointment> scheduledAppointments { get; set; }

        public DbSet<IsaProject.Models.Entities.Subscription> Subscription { get; set; }

        public DbSet<IsaProject.Models.Entities.Appeal> Appeal { get; set; }

        public DbSet<Isa.Models.Rating> Rating { get; set; }

        public DbSet<IsaProject.Models.Entities.ProfileDelete> ProfileDelete { get; set; }



    }
}
