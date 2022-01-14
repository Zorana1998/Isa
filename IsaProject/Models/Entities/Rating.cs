using IsaProject.Models.Entities;
using IsaProject.Models.Users;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Isa.Models
{

    
    public class Rating
    {
        public Rating(string employeeId, int score, bool isApproved)
        {
            EmployeeID = employeeId;
            Score = score;
            IsApproved = isApproved; 
        }

        public Rating(long entityId, int score, bool isApproved)
        {
            IsApproved = isApproved;
            EntityID = entityId;
            Score = score;
        }

        public Rating()
        {

        }

        public long Id { get; set; }
        [Required]
        public AppUser User { get; set; }
        public long EntityID { get; set; }
        public string EmployeeID { get; set; }
        public int Score { get; set; }

        public bool IsApproved { get; set; }

        /*[Timestamp]
        public byte[] RowVersion { get; set; }*/
    }
}
