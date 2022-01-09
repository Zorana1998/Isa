using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaProject.Models.Entities.Adventure
{
    public class AdventureImage
    {
        [Key]
        [Required]
        public long Id { get; set; }

        public byte[] ImageByte { get; set; }

        public string ImagePath { get; set; }

        [ForeignKey("Adventure")]
        public long AdventureID { get; set; }
    }
}
