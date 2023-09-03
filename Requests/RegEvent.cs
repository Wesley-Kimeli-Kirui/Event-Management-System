using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApplication.Requests
{
    public class RegEvent
    {
        // register for an event
        public int UserId { get; set; }
        public int EventId { get; set; }

    }
}