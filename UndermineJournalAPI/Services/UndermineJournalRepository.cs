using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UndermineJournalAPI.Models.Db;

namespace UndermineJournalAPI.Services
{
    public class UndermineJournalRepository : IUndermineJournalRepository
    {
        private readonly newsstandContext _context;
        
        public UndermineJournalRepository(newsstandContext context)
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

        public TblItemHistoryDaily GetItemDailyHistory(int itemId)
        {
            throw new NotImplementedException();
        }

    }
}
