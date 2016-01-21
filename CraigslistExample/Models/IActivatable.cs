using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraigslistExample.Models {
    public interface IActivatable {

        bool Active { get; set; }
    }
}
