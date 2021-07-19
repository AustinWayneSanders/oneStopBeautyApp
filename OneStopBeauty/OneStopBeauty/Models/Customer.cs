//Create by Austin Sanders-05/05/2021
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OneStopBeauty.Models
{
    public class Customer: Person
    {
        [Display(Name="Hair Color")]
        [MaxLength(15, ErrorMessage = "Subject Name must be 15 characters or less")]
        [RegularExpression("^[a-zA-z_ ]+$", ErrorMessage = "Hair color must be Letters Only")]
        public string Hair_Color { get; set; }
        [Display(Name="Skin Tone")]
        [MaxLength(15, ErrorMessage = "Skin tone must be 15 characters or less")]
        [RegularExpression("^[a-zA-z_ ]+$", ErrorMessage = "Skin tone must be Letters Only")]
        public string Skin_Color { get; set; }
        [Display(Name="Eye Color")]
        [MaxLength(15, ErrorMessage = "Eye color must be 15 characters or less")]
        [RegularExpression("^[a-zA-z_ ]+$", ErrorMessage = "Eye color must be Letters Only")]
        public string Eye_Color { get; set; }

        public virtual ICollection<BillingStatement> BillingStatements { get; set; }


    }
}
