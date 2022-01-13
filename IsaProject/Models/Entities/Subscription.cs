using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaProject.Models.Entities
{
    public class Subscription
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [ForeignKey("AppUser")]
        public string OwnerID { get; set; }

        [ForeignKey("Entity")]
        public long EntityID { get; set; }


        public Subscription()
        {
        }

        public Subscription(string ownerId, long entityId)
        {
            OwnerID = ownerId;
            EntityID = entityId;
        }
    }
}
