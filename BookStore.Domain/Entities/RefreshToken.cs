using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Entities
{
    public class RefreshToken
    {
        [Key]
        public int UserId { get; set;}
        
        public string? TokenId { get; set;}

        public string? RefreshTokenContainer { get; set;}

        public bool? isActive { get; set;}
    
    }
}
