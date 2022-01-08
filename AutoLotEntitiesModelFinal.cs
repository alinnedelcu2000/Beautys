using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AutoLotModelFINAL1
{
    public partial class AutoLotEntitiesModelFinal : DbContext
    {
        public AutoLotEntitiesModelFinal()
            : base("name=AutoLotEntitiesModelFinal")
        {
        }

        public virtual DbSet<Appoitment> Appoitment { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Hairstyle> Hairstyle { get; set; }
        public virtual DbSet<services> services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>()
                .Property(e => e.First_Name)
                .IsFixedLength();

            modelBuilder.Entity<Customers>()
                .Property(e => e.Last_Name)
                .IsFixedLength();

            modelBuilder.Entity<Employees>()
                .Property(e => e.description)
                .IsFixedLength();

            modelBuilder.Entity<Employees>()
                .Property(e => e.employees1)
                .IsFixedLength();

            modelBuilder.Entity<services>()
                .Property(e => e.Description)
                .IsFixedLength();
        }
    }
}
