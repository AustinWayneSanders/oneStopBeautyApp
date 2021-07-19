//Create by Austin Sanders-05/05/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OneStopBeauty.Models;

namespace OneStopBeauty.ViewModels
{
    public class InventorySearchViewModel
    {
        public Inventory Inventory { get; set; }
        public string SearchError { get; set; }
        public List<Inventory> ResultList { get; set; }
        public InventorySearchViewModel()
        {
            ResultList = new List<Inventory>();
        }
    }
}
