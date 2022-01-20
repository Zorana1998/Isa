using IsaProject.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace IsaProject.Models.Entities
{
    public class ProfileDelete
    {
        public ProfileDelete(string user, bool isApproved)
        {
            IsApproved = isApproved;
            UserId = user;
        }

        

        public ProfileDelete()
        {

        }

        public long Id { get; set; }
        [Required]
        public string UserId { get; set; }
        
        public string Content { get; set; }

        public bool IsApproved { get; set; }

        
        public string AdminResponseId { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
