namespace cis237assignment6.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class beveragesContext : DbContext
    {
        public beveragesContext()
            : base("name=beveragesContext")
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
