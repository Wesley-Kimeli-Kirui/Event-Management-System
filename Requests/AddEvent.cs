using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApplication.Requests
{
    public class AddEvent
    {

        [Required]
        [MinLength(8)]
        [MaxLength(50)]
        public string Name { get; set; } = "New Event";
        [Required]
        [MinLength(8)]
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
        [Required]
        [MinLength(8)]
        [MaxLength(50)]
        public string Location { get; set; } = "Nairobi";
        [Required]
        [Range(1, 50)]
        public int Slots { get; set; } = 30;
        [Required]
        [Range(1, 50)]
        public double Price { get; set; } = 2000;
        [Required]
        public DateTime EventDate { get; set; } = DateTime.Now;
    }
}