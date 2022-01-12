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

        public bool ChoosenByUser { get; set; }

        [ForeignKey("AppointmentDTO")]
        public long? AppointmentDTOID { get; set; }

        public AppointmentTag()
        {
        }

        public AppointmentTag(long appointmentID, long appointmentDTOID, long tagId, bool choosenByUser)
        {
            AppointmentID = appointmentID;
            AppointmentDTOID = appointmentDTOID;
            TagId = tagId;
            ChoosenByUser = choosenByUser;
        }

        public AppointmentTag(long appointmentID, long tagId)
        {
            AppointmentID = appointmentID;
            TagId = tagId;
        }
    }
}
