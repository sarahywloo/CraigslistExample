using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CraigslistExample.Models {
    public class Listing : IDbEntity, IActivatable {

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Url]
        public string Picture { get; set; }
        public Category Category { get; set; }
        public User Owner { get; set; }

        public bool Active { get; set; } = true;
    }
}