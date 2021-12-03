using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UndermineJournalAPI.Models.Db;
namespace UndermineJournalAPI.Services
{
    public class RealmRepository : IRealmRepository
    {
        private newsstandContext _context;

        public RealmRepository(newsstandContext context)
        {
            _context = context;
        }

        public IEnumerable<TblRealm> GetRealmByQuery(string query, string region)
        {
            if (string.IsNullOrWhiteSpace(query) || string.IsNullOrWhiteSpace(region))
            {
                return Enumerable.Empty<TblRealm>();
            }
            //query = query.ToLowerInvariant();
            //region = region.ToLowerInvariant();

            var realmList = _context.TblRealms
                .Where(w => (w.Name.Contains(query)
                || w.Slug.Contains(query)) && w.Region == region).Take(5).ToList();
            return realmList;
        }
    }
}
