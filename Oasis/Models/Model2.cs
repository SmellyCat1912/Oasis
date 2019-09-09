namespace Oasis.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Film_Model")
        {
        }

        public virtual DbSet<film> films { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<film>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<film>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<film>()
                .Property(e => e.desc)
                .IsFixedLength();

            modelBuilder.Entity<film>()
                .Property(e => e.theatre_id)
                .IsFixedLength();
        }
    }
}
