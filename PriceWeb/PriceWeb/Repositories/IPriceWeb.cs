using PriceWeb.ValidationModels.Post;

namespace PriceWeb.Repositories
{
    public interface IPriceWeb
    {
        Models.Item GetItem(int id);
        Models.Stockstate GetStockState(int itemId, string gln);
        Models.Stockstate[] GetAllStockStates();
        Models.Stockstate[] GetInventoryForItemsOnPharmacies(ItemsAndPharmacies model);
        object GetStockStatesForItem(int itemNo);
    }
}
