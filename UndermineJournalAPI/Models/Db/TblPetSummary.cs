using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblPetSummary
    {
        public short House { get; set; }
        public short Species { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
