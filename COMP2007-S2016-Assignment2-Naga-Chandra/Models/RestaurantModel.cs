namespace COMP2007_S2016_Assignment2_Naga_Chandra.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantModel : DbContext
    {
        public RestaurantModel()
            : base("name=Restaurantconnection")
        {
        }

        public virtual DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
