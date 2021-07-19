//Create by Austin Sanders-05/05/2021
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OneStopBeauty.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        [Display(Name="Product Name")]
        public string Product_Name { get; set; }
        [RegularExpression("^[+]?[0-9]*[.]?[0-9]*$", ErrorMessage = "Price must be a postive decimal number")]
        [Display(Name="Price")]
        public decimal Unit_Price { get; set; }

        [MaxLength(50, ErrorMessage = "Skin tone must be 50 characters or less")]
        [RegularExpression("^[a-zA-z_ ]+$", ErrorMessage = "Purpose must be Letters Only")]
        public string Purpose { get; set; }

        public virtual ICollection<ItemSold> ItemsSold { get; set; }
        public virtual ICollection<ItemOrdered> ItemsOrdered { get; set; }



    }
}
