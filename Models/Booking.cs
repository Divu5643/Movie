using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBookingApp.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        public int ShowTimeID { get; set; }
        public int NumberOfSeats { get; set; } = 100;

        public string UserName { get; set; }

        public string UserEmail { get; set; }
    }
}