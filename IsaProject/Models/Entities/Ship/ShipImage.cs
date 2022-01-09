using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaProject.Models
{
    public class ShipImage
    {
        [Key]
        [Required]
        public long Id { get; set; }

        public byte[] ImageByte { get; set; }

        public string ImagePath { get; set; }

        [ForeignKey("Ship")]
        public long ShipID { get; set; }
    }
}