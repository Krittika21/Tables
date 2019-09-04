using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZomatoTables.Models
{
    public class EachRestaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual Location Location { get; set; }

    }
}
