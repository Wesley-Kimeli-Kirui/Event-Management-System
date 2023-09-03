using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApplication.Models
{
    public class Events
    {
        public int Id { get; set; }
        public string Name { get; set; } = "New Event";
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = "Nairobi";
        public int Slots { get; set; } = 30;
        public double Price { get; set; } = 2000;
        public DateTime EventDate { get; set; }

        public List<Users> Users { get; set; } = new List<Users>();

    }
}