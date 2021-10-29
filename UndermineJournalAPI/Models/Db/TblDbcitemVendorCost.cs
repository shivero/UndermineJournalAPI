using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblDbcitemVendorCost
    {
        public int Item { get; set; }
        public int? Copper { get; set; }
        public int? Npc { get; set; }
        public short? Npccount { get; set; }
    }
}
