using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblDbcspellReagent
    {
        public int Spell { get; set; }
        public int Item { get; set; }
        public short Qty { get; set; }
    }
}
