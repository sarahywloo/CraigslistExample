using CraigslistExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CraigslistExample.Controllers
{
    public class ListingsController : ApiController {
        private ApplicationDbContext _db = new ApplicationDbContext();

        public List<Listing> Get() {

            //longhand
            //var listings = (from l in _db.Listings
            //                select l).ToList();
            return _db.Listings.ToList();
        }
    }
}
