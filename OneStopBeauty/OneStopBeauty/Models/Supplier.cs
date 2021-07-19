using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//Create by Austin Sanders-05/05/2021
using System.Linq;
using System.Threading.Tasks;

namespace OneStopBeauty.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        [RegularExpression("^[a-zA-z_]+$", ErrorMessage = "Please provide only character values.")]
        [MaxLength(50, ErrorMessage = "Supplier name must be 50 characters or less")]
        public string Name { get; set; }
        [Display(Name="Street Address")]
        [MaxLength(100, ErrorMessage = "Street Address must be 100 characters or less")]
        [RegularExpression("^[a-zA-z_ 0-9]+$", ErrorMessage = "This field does not allow special characters.")]
        public string Street_Address { get; set; }
        [MaxLength(50, ErrorMessage = "City must be 50 characters or less")]
        [RegularExpression("^[a-zA-z_]+$", ErrorMessage = "Please provide only character values.")]
        public string City { get; set; }
        [MaxLength(15, ErrorMessage = "State must be 15 characters or less")]
        [RegularExpression("^[a-zA-z_]+$", ErrorMessage = "Please provide only character values.")]
        public string State { get; set; }
        [Display(Name="Zip Code")]
        [RegularExpression("([0-9]+)", ErrorMessage = "This field only accepts numeric values.")]
        public string Zip_Code { get; set; }

        public virtual ICollection<ItemOrdered> ItemsOrdered { get; set; }

    }
}
