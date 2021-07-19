//Create by Austin Sanders-05/05/2021
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OneStopBeauty.Models
{
    public class ItemSold
    {
        public int ItemSoldID { get; set; }
        [Display(Name = "Invoice Number")]
        public int? BillingStatementID { get; set; }
        [Display(Name = "Invoice Number")]
        [Required(ErrorMessage= "Invoice Number is a Required Field")]
        public virtual BillingStatement BillingStatement { get; set; }
        public int? InventoryID { get; set; }
        public virtual Inventory Inventory { get; set; }
        public int? ServiceID { get; set; }
        public virtual Service Services { get; set; }
        public int? LocationID { get; set; }
        [Display(Name = "Store Number")]
        public virtual Location Location { get; set; }
        public bool Online { get; set; }
        [Display(Name = "Shipped Date")]
        public DateTime Shipped_Date_Sold_Item { get; set; }
        [Display(Name = "Arrived Date")]
        public DateTime Arrived_Date_Sold_Item { get; set; }

        [RegularExpression("^[+]?[0-9]*[.]?[0-9]*$", ErrorMessage = "Extended price must be a postive decimal number")]
        [Display(Name = "Extended Price")]
        public decimal Ext_Price { get; set; }
        public int Quantity { get; set; }
        [RegularExpression("^[+]?[0-9]*[.]?[0-9]*$", ErrorMessage = "Discount must be a postive decimal number")]
        public double Discount { get; set; }

       

    }
}
