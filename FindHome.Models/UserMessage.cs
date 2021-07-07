using Microsoft.AspNetCore.Identity;

namespace FindHome.Models
{
    public class UserMessage
    {
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        
        public int MessageId { get; set; }
        public Message Message { get; set; }
    }
}
