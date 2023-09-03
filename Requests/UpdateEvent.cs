using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApplication.Requests
{
    public class UpdateEvent
    {
        [Required]
        [MinLength(8)]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MinLength(8)]
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
        [Required]
        [MinLength(8)]
        [MaxLength(50)]
        public string Location { get; set; } = string.Empty;
        [Required]
        public int Slots { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTime EventDate { get; set; } = DateTime.Now;
    }
}