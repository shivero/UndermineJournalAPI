using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblDbcpet
    {
        public short Id { get; set; }
        public string NameEnus { get; set; }
        public string NameDede { get; set; }
        public string NameEses { get; set; }
        public string NameFrfr { get; set; }
        public string NameItit { get; set; }
        public string NamePtbr { get; set; }
        public string NameRuru { get; set; }
        public string NameKokr { get; set; }
        public string NameZhtw { get; set; }
        public byte Type { get; set; }
        public string Icon { get; set; }
        public int? Npc { get; set; }
        public byte? Category { get; set; }
        public int? Flags { get; set; }
        public short? Power { get; set; }
        public short? Stamina { get; set; }
        public short? Speed { get; set; }
    }
}
