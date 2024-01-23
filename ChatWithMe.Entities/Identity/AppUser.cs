using ChatWithMe.Entities.Entities;
using Microsoft.AspNetCore.Identity;

namespace ChatWithMe.Entities.Identity
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Messages = new HashSet<Message>();
        }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
