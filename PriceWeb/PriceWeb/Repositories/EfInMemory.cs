using System;
using System.Linq;
using PriceWeb.Models;
using PriceWeb.ValidationModels.Post;

namespace PriceWeb.Repositories
{
    public class EfInMemory : IPriceWeb
    {
        private EfDbContext _context;
        private static int count; 

        public EfInMemory(EfDbContext context)
        {
            _context = context;

            if (_context.Items.Count() != 0)
                return;

            _context.Items.Add(new Item()
            {
                Id = 0,
                Description = "Hello In Memory World"
            });

            _context.Stockstates.Add(new Stockstate()
            {
                Id = 0,
                ItemId = 1,
                OnStock = 2,
                PharmacyId = "2"
            });

            _context.SaveChanges();

        }

        public Stockstate[] GetAllStockStates()
        {
            throw new NotImplementedException();
        }

        public Stockstate[] GetInventoryForItemsOnPharmacies(ItemsAndPharmacies model)
        {
            IQueryable<Stockstate> item = null;

                item = from o in _context.Stockstates
                       where (model.ItemIds.Contains(o.ItemId) && model.PharmacyIds.Contains(o.PharmacyId))
                       select o;

            return item?.ToArray();
        }

        public Item GetItem(int id)
        {
            return _context.Items.FirstOrDefault(o => o.Id == 1);
        }

        public Stockstate GetStockState(int itemId, string gln)
        {
            return _context.Stockstates.SingleOrDefault(o => (o.ItemId == itemId) && (o.PharmacyId == gln));
        }

        public Stockstate[] GetStockStatesForItem(int itemNo)
        {
            throw new NotImplementedException();
        }
    }
}
