using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UndermineJournalAPI.Models.Data
{
    public class ItemHistoryDailyDTO
    {
        public int itemId { get; set; }
        public int realmId { get; set; }
        public DateTime date { get; set; }
        public int price_min { get; set; }
        public int price_max { get; set; }
        public int price_avg { get; set; }
        public int price_start { get; set; }
        public int price_end { get; set; }
        public int quantity_min { get; set; }
        public int quantity_avg { get; set; }
        public int quantity_max { get; set; }
    }
}
