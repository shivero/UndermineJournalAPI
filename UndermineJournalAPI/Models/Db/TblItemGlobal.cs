using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblItemGlobal
    {
        public int Item { get; set; }
        public short Level { get; set; }
        public string Region { get; set; }
    }
}
