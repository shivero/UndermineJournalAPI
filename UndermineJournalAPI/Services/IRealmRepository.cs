using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UndermineJournalAPI.Models.Db;
namespace UndermineJournalAPI.Services
{
    public interface IRealmRepository
    {
        public IEnumerable<TblRealm> GetRealmByQuery(string query,string region);
    }
}
