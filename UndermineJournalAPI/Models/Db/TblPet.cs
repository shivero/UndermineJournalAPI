using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblPet
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Json { get; set; }
        public byte Type { get; set; }
        public string Icon { get; set; }
        public int? Npc { get; set; }
    }
}
