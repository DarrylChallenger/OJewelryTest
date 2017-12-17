namespace OJewelryTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OJewelryDC : DbContext
    {
        public OJewelryDC()
            : base("name=OJewelryDC")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Collection> Collections { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<ComponentType> ComponentTypes { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<JewelryType> JewelryTypes { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }

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

            modelBuilder.Entity<Component>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Component>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Component>()
                .Property(e => e.PricePerHour)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Component>()
                .Property(e => e.PricePerPiece)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Component>()
                .Property(e => e.MetalMetal)
                .IsUnicode(false);

            modelBuilder.Entity<Component>()
                .Property(e => e.MetalLabor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Component>()
                .Property(e => e.StoneSize)
                .IsUnicode(false);

            modelBuilder.Entity<Component>()
                .Property(e => e.StonePPC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Component>()
                .Property(e => e.FindingsMetal)
                .IsUnicode(false);

            modelBuilder.Entity<ComponentType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.StyleNum)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.StyleName)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.RetailRatio)
                .HasPrecision(8, 5);

            modelBuilder.Entity<Item>()
                .Property(e => e.RedlineRatio)
                .HasPrecision(8, 5);

            modelBuilder.Entity<JewelryType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.Nampe)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
