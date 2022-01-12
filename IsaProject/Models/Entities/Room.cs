using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaProject.Models.Entities
{
    public class Room
    {
        [Key]
        [Required]
        public long Id { get; set; }
        [Required]
        public int NumberOfBeds { get; set; }

        [ForeignKey("Cottage")]
        public long CottageID { get; set; }
    }
}
