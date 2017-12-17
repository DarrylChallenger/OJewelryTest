namespace OJewelryTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        public int Id { get; set; }

        [StringLength(15)]
        public string StyleNum { get; set; }

        [StringLength(50)]
        public string StyleName { get; set; }

        [StringLength(150)]
        public string Desc { get; set; }

        public int? JewelryTypeId { get; set; }

        public int? CollectionId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IntroDate { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        public int? Width { get; set; }

        public int? Length { get; set; }

        public int? ChainLength { get; set; }

        public decimal? RetailRatio { get; set; }

        public decimal? RedlineRatio { get; set; }

        public int? ComponentId { get; set; }

        public int? Quantity { get; set; }

        public virtual Collection Collection { get; set; }

        public virtual Component Component { get; set; }

        public virtual JewelryType JewelryType { get; set; }
    }
}
