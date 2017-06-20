using System.ComponentModel.DataAnnotations;

namespace PriceWeb.ValidationModels.Post
{
    public class ItemsAndPharmacies
    {
        [Required(ErrorMessage = "Data required for this service: ItemIds")]
        public int[] ItemIds { get; set; }

        [Required(ErrorMessage = "Data required for this service: PharmacyIds")]
        public string[] PharmacyIds { get; set; }
    }
}
