using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UndermineJournalAPI.Models.Db;

namespace UndermineJournalAPI.Services
{
    public class ItemRepository : IItemRepository
    {
        private readonly newsstandContext _context;
        
        public ItemRepository(newsstandContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IEnumerable<TblDbcitem> GetItemsByName(string searchPhrase, string locale)
        {
            if (string.IsNullOrWhiteSpace(searchPhrase))
            {
                return null;
            }
            var results = _context.TblDbcitems.Where(w => w.NameEnus.Contains(searchPhrase)).ToList();
            
            return results;
        }

        public IEnumerable<TblItemHistoryDaily> GetItemDailyHistory(int itemId, int realmId)
        {
            if (realmId == 0)
            {
                throw new ArgumentException("You have not selected realm, id: 0");
            }
            if (itemId == 0)
            {
                throw new ArgumentException("Item id value 0");
            }
            var dailyHistory = _context.TblItemHistoryDailies.Where(w => w.Item == itemId && w.House == realmId).ToList();
            return dailyHistory;
        }

    }
}
