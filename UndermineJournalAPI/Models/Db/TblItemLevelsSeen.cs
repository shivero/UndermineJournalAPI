using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblItemLevelsSeen
    {
        public int Item { get; set; }
        public byte Bonusset { get; set; }
        public short Level { get; set; }
    }
}
