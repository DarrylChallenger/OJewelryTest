using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OJewelryTest.Models
{
    public class NewClientViewModel
    {
        [Key] public int Id { get; set; }
        public String ClientName { get; set; }
        public String ClientPhone { get; set; }
        public String ClientEmail { get; set; }
        public String CompanyName { get; set; }
        public virtual List<SelectListItem> Companies { get; set; }
    }
}