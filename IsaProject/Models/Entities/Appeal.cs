using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaProject.Models.Entities
{
    public class Appeal
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [ForeignKey("AppUser")]
        public string UserApprovalSendID { get; set; }

        [ForeignKey("Entity")]
        public long? EntityID { get; set; }

        [ForeignKey("AppUser")]
        public string? UserApprovalReceivedID { get; set; }

        [Required]
        public string Content { get; set; }

        public bool IsAnswered { get; set; }

        public string ContentAnswer { get; set; }




        public Appeal()
        {
        }

        public Appeal(long entityId)
        {
            EntityID = entityId;
        }

        public Appeal(string userApprovalSendID, long entityId, string content, bool isAnswer)
        {
            UserApprovalReceivedID = userApprovalSendID;
            EntityID = entityId;
            Content = content;
            IsAnswered = isAnswer;
        }

        public Appeal(string userApprovalSendID, string userApprovalReceivedID, string content, bool isAnswer)
        {
            UserApprovalReceivedID = userApprovalSendID;
            UserApprovalReceivedID = userApprovalReceivedID;
            Content = content;
            IsAnswered = isAnswer;
        }

    }
}
