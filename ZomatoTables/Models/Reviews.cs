using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZomatoTables.Models
{
    public class Reviews
    {
        public int ID { get; set; }
        public int LikesCount { get; set; }
        public string ReviewTexts { get; set; }

        public virtual EachRestaurant Restaurant { get; set; }
        public virtual Users User { get; set; }
    }
}
