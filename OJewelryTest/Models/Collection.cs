namespace OJewelryTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Collection
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual Company Company { get; set; }
    }
}
