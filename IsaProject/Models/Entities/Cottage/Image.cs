using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaProject.Models
{
    public class Image
    {
        [Key]
        [Required]
        public long Id { get; set; }

        public byte[] ImageByte { get; set; }

        public string ImagePath { get; set; }

        [ForeignKey("Entity")]
        public long EntityID { get; set; }
    }
}
