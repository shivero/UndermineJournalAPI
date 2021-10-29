using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblItemSummary
    {
        public short House { get; set; }
        public int Item { get; set; }
        public short Level { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
