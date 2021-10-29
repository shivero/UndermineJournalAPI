using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblItemBonusesSeen
    {
        public int Item { get; set; }
        public short Bonus1 { get; set; }
        public short Bonus2 { get; set; }
        public short Bonus3 { get; set; }
        public short Bonus4 { get; set; }
        public int Observed { get; set; }
    }
}
