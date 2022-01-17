using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaProject.Models.Users
{
    [Table("tbAppUsers")]
    public class AppUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        [PersonalData]
        public string Address { get; set; }
        [PersonalData]
        public string Country { get; set; }
        [PersonalData]
        public string City { get; set; }
        [PersonalData]
        public int Penalty { get; set; }

        
        public string Explanation { get; set; }

        public string ReasonForReject { get; set; }

        public float AverageScore { get; set; }

        public bool isFirstlogin { get; set; }

        /*[Timestamp]
        public byte[] RowVersion { get; set; }*/
    }
}
