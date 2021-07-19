//Create by Austin Sanders-05/05/2021
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OneStopBeauty.Models
{
    public class BillingStatement
    {
        [Display(Name="Invoice Number")]
        public int BillingStatementID { get; set; }
        // [Display(Name="Customer Name")]
        [Required(ErrorMessage = "Customer Name is a Required Field")]
        public int? CustomerID { get; set; }
     
        public virtual Customer Customer { get; set; }
        public int? EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        [Display(Name="Invoice Date")]
        public DateTime Invoice_Date { get; set; }
        [Display(Name="Total Price")]
        public decimal Total_Price { get; set; }
        public decimal Taxes { get; set; }


        public virtual ICollection<ItemSold> ItemsSold { get; set; }

    }
}
