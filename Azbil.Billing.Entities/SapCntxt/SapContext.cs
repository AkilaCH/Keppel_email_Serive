namespace Azbil.Billing.Entities.SapCntxt
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SapContext : DbContext
    {
        public SapContext()
            : base("name=SapContext")
        {
        }

        public virtual DbSet<DeclaredDemand> DeclaredDemands { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeclaredDemand>()
                .Property(e => e.Building_Code)
                .IsUnicode(false);
        }
    }
}
