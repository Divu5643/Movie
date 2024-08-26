using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieBookingApp.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Book(int id)
        {

            return View();
        }
        public ActionResult Confirm()
        {
            return View();
        }
    }
}