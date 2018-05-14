/*Author: Daniel Garson
CIS 237
Assignment 5
Due: 4-2-18
*/

namespace cis237assignment5
{
    
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    //server connection
    public partial class BeveragesDBContext : DbContext
    {
        public BeveragesDBContext()
            : base("name=BeverageDBContext")
        {
        }

        public virtual DbSet<Beverage> Beverages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beverage>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Beverage>()
                .Property(e => e.pack)
                .IsFixedLength();

            modelBuilder.Entity<Beverage>()
                .Property(e => e.price)
                .HasPrecision(19, 4);
        }
    }
}
