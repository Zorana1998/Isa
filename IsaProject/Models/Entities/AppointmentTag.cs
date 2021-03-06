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

        [ForeignKey("AppointmentDTO")]
        public long? AppointmentDTOID { get; set; }

        [ForeignKey("ScheduledAppointment")]
        public long? ScheduleAppointmentId { get; set; }

        public AppointmentTag()
        {
        }

        public AppointmentTag(long appointmentID, long appointmentDTOID, long tagId)
        {
            AppointmentID = appointmentID;
            AppointmentDTOID = appointmentDTOID;
            TagId = tagId;
        }

        public AppointmentTag(long appointmentID, long tagId)
        {
            AppointmentID = appointmentID;
            TagId = tagId;
        }

        public AppointmentTag(long appointmentID, long appointmentDTOID, long tagId, long scheduleAppointmentId)
        {
            AppointmentID = appointmentID;
            AppointmentDTOID = appointmentDTOID;
            TagId = tagId;
            ScheduleAppointmentId = scheduleAppointmentId;
        }
    }
}
