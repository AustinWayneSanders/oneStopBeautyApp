//Create by Austin Sanders-05/05/2021
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OneStopBeauty.Models
{
    public class Service
    {
        public int ServiceID { get; set; }
        [Display(Name="Service")]
        [MaxLength(50, ErrorMessage = "State must be 50 characters or less")]
        [RegularExpression("^[a-zA-z_]+$", ErrorMessage = "Please provide only character values.")]
        public string Service_Rendered { get; set; }
        [Display(Name="Service Type")]
        [MaxLength(50, ErrorMessage = "Service Type must be 50 characters or less")]
        [RegularExpression("^[a-zA-z_]+$", ErrorMessage = "Please provide only character values.")]
        public string Service_Type { get; set; }
        [RegularExpression("^[+]?[0-9]*[.]?[0-9]*$", ErrorMessage = "Service price must be a postive decimal number")]
        [Display(Name="Price")]
        public decimal Service_Price { get; set; }

        public virtual ICollection<ItemSold> ItemsSold { get; set; }
    }
}
