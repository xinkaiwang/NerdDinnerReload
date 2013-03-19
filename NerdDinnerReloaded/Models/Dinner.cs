using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NerdDinnerReloaded.Models
{
    public class Dinner
    {
        public int DinnerID { get; set; }
        public string Title { get; set; }
        public DateTime EventDate { get; set; }
        public String Address { get; set; }
        public String HostedBy { get; set; }

        public virtual ICollection<RSVP> RSVPs { get; set; }
    }

    public class RSVP
    {
        public int RsvpID { get; set; }
        public int DinnerID { get; set; }
        public string AddendeeEmail { get; set; }

        public virtual Dinner Dinner { get; set; }
    }
}
