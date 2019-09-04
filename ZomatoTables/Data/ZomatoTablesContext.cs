using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ZomatoTables.Models
{
    public class ZomatoTablesContext : DbContext
    {
        public ZomatoTablesContext (DbContextOptions<ZomatoTablesContext> options)
            : base(options)
        {
        }

        public DbSet<ZomatoTables.Models.EachRestaurant> EachRestaurant { get; set; }
        public DbSet<ZomatoTables.Models.City> City { get; set; }
        public DbSet<ZomatoTables.Models.Country> Country { get; set; }
        public DbSet<ZomatoTables.Models.Dishes> Dishes { get; set; }
        public DbSet<ZomatoTables.Models.DishesOrdered> OrderedDishes { get; set; }
        public DbSet<ZomatoTables.Models.Likes> Likes { get; set; }
        public DbSet<ZomatoTables.Models.Location> Locations { get; set; }
        public DbSet<ZomatoTables.Models.OrderDetails> OrderDetails { get; set; }
        public DbSet<ZomatoTables.Models.Rating> Ratings { get; set; }
        public DbSet<ZomatoTables.Models.Reviews> Reviews { get; set; }
        public DbSet<ZomatoTables.Models.UserFollow> Follows { get; set; }
        public DbSet<ZomatoTables.Models.Users> Users { get; set; }
    }
}
