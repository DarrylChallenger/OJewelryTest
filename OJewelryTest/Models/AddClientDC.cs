namespace OJewelryTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AddClientDC : DbContext
    {
        public AddClientDC()
            : base("name=AddClientDC")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Collection> Collections { get; set; }
        public virtual DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Collection>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<OJewelryTest.Models.NewClientModel> NewClientModels { get; set; }

        //public System.Data.Entity.DbSet<OJewelryTest.Models.NewClientViewModel> NewClientViewModels { get; set; }
    }
}
