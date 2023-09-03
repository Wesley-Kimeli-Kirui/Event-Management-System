using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApplication.Response
{
    public class EventsUsersResponse
    {
        public string Name { get; set; } = string.Empty;
        public string EventDate { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public double Price { get; set; }
        public List<UsersResponseDto> Users { get; set; } = new List<UsersResponseDto>();
    }

    public class UsersResponseDto
    {
        public string PhoneNumber { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}