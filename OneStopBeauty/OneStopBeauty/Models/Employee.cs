using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//Create by Austin Sanders-05/05/2021
using System.Linq;
using System.Threading.Tasks;

namespace OneStopBeauty.Models
{
    public class Employee: Person
    {

        [Display(Name="Position Title")]
        [MaxLength(50, ErrorMessage = "Position must be 50 characters or less")]
        [RegularExpression("^[a-zA-z_ ]+$", ErrorMessage = "Position title must be Letters Only")]
        public string Position_Title { get; set; }
        [Display(Name="Months Employeed")]
        [RegularExpression("([0-9]+)", ErrorMessage= "Months employeed needs to be a numeric value")]
        public int Months_Employeed { get; set; }
        [Display(Name="Pay Rate")]
        [RegularExpression("^[+]?[0-9]*[.]?[0-9]*$", ErrorMessage = "Pay rate must be a postive decimal number")]
        public float Pay_Rate { get; set; }

        public virtual ICollection<BillingStatement> BillingStatements { get; set; }

    }
}
