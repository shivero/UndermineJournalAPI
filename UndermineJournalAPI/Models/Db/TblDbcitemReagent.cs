using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblDbcitemReagent
    {
        public int Item { get; set; }
        public short Skillline { get; set; }
        public short Subline { get; set; }
        public int Reagent { get; set; }
        public int? Spell { get; set; }
    }
}
