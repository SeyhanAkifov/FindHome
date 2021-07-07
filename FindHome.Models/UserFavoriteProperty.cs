using Microsoft.AspNetCore.Identity;

namespace FindHome.Models
{
    public class UserFavoriteProperty
    {
        public string UserId { get; set; }

        public IdentityUser User { get; set; }
        public string PropertyId { get; set; }
        public Property Property { get; set; }
    }
}
