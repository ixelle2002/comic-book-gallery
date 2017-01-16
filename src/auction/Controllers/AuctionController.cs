using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace auction.Controllers
{
    public class AuctionController : Controller
    {
        // GET: Auction
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Auction()
        {
            var auction = new auction.Models.Auction()
            {
                Title = "Example Auction",
                Description = "This is an example",
                StartTime = DateTime.Now,
                EntTime = DateTime.Now.AddDays(7),
                StartPrice = 1.00m,
                CurrentPrice = null,
            };

            ViewData["Auction"] = auction;
            return View();
        }

    } 
}