using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PriceWeb.ViewModels.Post
{
    public class ItemsAndPharmacies
    {
        [Required]
        public int[] ItemIds { get; set; }
        [Required]
        public string[] PharmacyIds { get; set; }
    }
}
