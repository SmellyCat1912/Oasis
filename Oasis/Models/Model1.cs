namespace Oasis.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Theatre_Model")
        {
        }

        public virtual DbSet<Theatre> Theatres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Theatre>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Theatre>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Theatre>()
                .Property(e => e.desc)
                .IsFixedLength();
        }
    }
}
