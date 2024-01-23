using ChatWithMe.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWithMe.Entities.Entities
{
    public class Message
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Text { get; set; }

        public DateTime When { get; set; }

        public int UserId { get; set; } 

        public virtual AppUser AppUser { get; set; }

    }
}
