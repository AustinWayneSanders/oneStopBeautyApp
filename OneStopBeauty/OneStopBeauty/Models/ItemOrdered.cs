using System;
//Create by Austin Sanders-05/05/2021
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OneStopBeauty.Models
{
    public class ItemOrdered
    {
        public int ItemOrderedID { get; set; }
        public int? SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int? InventoryID { get; set; }
        public virtual Inventory Inventory { get; set; }
   
        [MaxLength(3, ErrorMessage = "Product Code must be 3 characters or less")]
        [RegularExpression("^[A-Z]+$", ErrorMessage = "Product Code must be UpperCase Letters")]
        [Display(Name="Product Code")]
        public string Product_Code { get; set; }
        [Display(Name="Shipped Date")]
        public DateTime Shipped_Date_Ordered_Item { get; set; }
        [Display(Name="Arrived Date")]
        public DateTime Arrived_Date_Ordered_Item { get; set; }
        
    }
}
