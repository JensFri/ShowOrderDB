namespace ShowOrderDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext()
            : base("name=NorthwindDB")
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Bestellungen> Bestellungen { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Order>()
                .Property(e => e.CustomerID)
                .IsFixedLength();

            modelBuilder.Entity<Order>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Bestellungen>().ToTable("Orders").HasKey(u=>u.CustomerID);
            
        }
    }
}
