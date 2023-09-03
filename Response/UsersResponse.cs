using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsApplication.Models;

namespace EventsApplication.Response
{
    public class UsersResponse
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<Events> Events { get; set; } = new List<Events>();
    }
}