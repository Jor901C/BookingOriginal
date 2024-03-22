using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BookingOriginal.WEB.Entities
{
    public class AllIDentity : IdentityUser
    {
        [Required]
        public string _Name { get; set; } = string.Empty;
        public string _Surname { get; set; } = string.Empty;
        public string _Country { get; set; } = string.Empty;
        public string _City { get; set; } = string.Empty;

    }
}
