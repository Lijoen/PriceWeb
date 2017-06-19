using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PriceWeb.Models;
using PriceWeb.ValidationModels.Post;

namespace PriceWeb.Repositories
{
    public class EfInMemory : IPriceWeb
    {
        private EfDbContext _context;

        public EfInMemory(EfDbContext context)
        {
            _context = context;

            _context.Items.Add(new Item() { Id = 1, Description = "Hello In Memory World" });
            _context.SaveChanges(); 
        }

        public Stockstate[] GetAllStockStates()
        {
            throw new NotImplementedException();
        }

        public Stockstate[] GetInventoryForItemsOnPharmacies(ItemsAndPharmacies model)
        {
            throw new NotImplementedException(); 
        }

        public Item GetItem(int id)
        {
            return _context.Items.FirstOrDefault(o => o.Id == 1);
        }

        public Stockstate GetStockState(int itemId, string gln)
        {
            throw new NotImplementedException();
        }
    }
}
