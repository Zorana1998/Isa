using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaProject.Models.Entities.Ship
{
    public class NavigationEquipment
    {
        [Key]
        [Required]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
