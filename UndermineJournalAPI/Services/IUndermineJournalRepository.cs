using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UndermineJournalAPI.Models.Db;
namespace UndermineJournalAPI.Services
{
    public interface IUndermineJournalRepository
    {
        IEnumerable<TblDbcitem> GetItemsByName(string searchPhrase, string locale);
        IEnumerable<TblItemHistoryDaily> GetItemDailyHistory(int itemId, int realmId);
    }
}