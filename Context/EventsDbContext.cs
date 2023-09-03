using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace EventsApplication.Context
{
    public class EventsDbContext : DbContext
    {
        public DbSet<Events> Events { get; set; }
        public DbSet<Users> Users { get; set; }
        public EventsDbContext(DbContextOptions<EventsDbContext> options) : base(options) { }
    }
}