using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZomatoTables.Models
{
    public class Rating
    {
        public int ID { get; set; }
        public decimal AverageRating { get; set; }

        public virtual EachRestaurant Restaurant { get; set; }
        public virtual Users User { get; set; }
    }
}
