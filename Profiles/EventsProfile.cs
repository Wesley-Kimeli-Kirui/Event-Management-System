using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsApplication.Models;
using EventsApplication.Requests;
using EventsApplication.Response;
using AutoMapper;

namespace EventsApplication.Profiles
{
    public class EventsProfile : Profile
    {
        public EventsProfile()
        {
            CreateMap<AddUSer, Users>().ReverseMap();
            CreateMap<UsersResponse, Users>().ReverseMap();

            CreateMap<AddEvent, Events>().ReverseMap();
            CreateMap<EventsResponse, Events>().ReverseMap();


            CreateMap<RegEvent, EventsUsersResponse>().ReverseMap();
        }
    }
}