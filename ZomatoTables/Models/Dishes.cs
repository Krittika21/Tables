﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZomatoTables.Models
{
    public class Dishes
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual EachRestaurant Restaurant { get; set; }
    }
}
