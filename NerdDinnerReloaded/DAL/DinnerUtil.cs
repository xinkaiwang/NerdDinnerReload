using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinnerReloaded.Models;

namespace NerdDinnerReloaded.DAL
{
    public static class DinnerUtil
    {
        public static void AddNewDinner()
        {
            NerdDinners db = new NerdDinners();
            var dinner = new Dinner()
            {
                Title = "xinkai's party",
                EventDate = DateTime.Parse("12/31/2013"),
                Address = "Building 40",
                HostedBy = "xinkai@inrix.com",
            };
            db.Dinners.Add(dinner);
            db.SaveChanges();
        }

        public static void UpdateADinner()
        {
            NerdDinners db = new NerdDinners();
            var dinner = db.Dinners.Find(1);
            dinner.Title = "Updated title";
            db.SaveChanges();
        }
    }
}