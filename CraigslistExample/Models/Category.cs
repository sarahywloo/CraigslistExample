using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraigslistExample.Models {
    public class Category : IDbEntity, IActivatable {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Listing> Listings { get; set; }

        public bool Active { get; set; } = true;
    }
}