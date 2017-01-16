using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace auction.Models
{
    public class Auction
    {

        public long Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EntTime { get; set; }

        public decimal StartPrice { get; set; }
        public decimal? CurrentPrice { get; set; }


    }
}