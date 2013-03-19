using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NerdDinnerReloaded.Models;

namespace NerdDinnerReloaded.DAL
{
    public class NerdDinners : DbContext
    {
        public DbSet<Dinner> Dinners { get; set; }
        public DbSet<RSVP> RSVPs { get; set; }
    }
}