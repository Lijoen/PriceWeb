using System.ComponentModel.DataAnnotations;

namespace PriceWeb.ValidationModels.Post
{
    public class ItemsAndPharmacies
    {
        [Required(ErrorMessage = "Required data: int[] ItemIds")]
        public int[] ItemIds { get; set; }

        [Required(ErrorMessage = "Required data: string[] PharmacyIds")]
        public string[] PharmacyIds { get; set; }
    }
}
