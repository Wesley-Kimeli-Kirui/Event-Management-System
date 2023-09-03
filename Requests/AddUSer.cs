using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApplication.Requests
{
    public class AddUSer
    {
        [Required]
        [MinLength(8)]
        [MaxLength(50)]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        [MinLength(8)]
        [MaxLength(50)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [MinLength(8)]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MinLength(8)]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}