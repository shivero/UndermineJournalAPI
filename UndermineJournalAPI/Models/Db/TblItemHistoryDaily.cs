using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblItemHistoryDaily
    {
        public int Item { get; set; }
        public short House { get; set; }
        public DateTime When { get; set; }
        public int Pricemin { get; set; }
        public int Priceavg { get; set; }
        public int Pricemax { get; set; }
        public int Pricestart { get; set; }
        public int Priceend { get; set; }
        public int Quantitymin { get; set; }
        public int Quantityavg { get; set; }
        public int Quantitymax { get; set; }
    }
}
