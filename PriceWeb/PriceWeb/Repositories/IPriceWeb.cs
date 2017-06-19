using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PriceWeb.ViewModels.Post;

namespace PriceWeb.Repositories
{
    public interface IPriceWeb
    {
        Models.Item GetItem(int id);
        Models.Stockstate GetStockState(int itemId, string gln);
        Models.Stockstate[] GetAllStockStates();
        Models.Stockstate[] GetInventoryForItemsOnPharmacies(ItemsAndPharmacies model);
    }
}
