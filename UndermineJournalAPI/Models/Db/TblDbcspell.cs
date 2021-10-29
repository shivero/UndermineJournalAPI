using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblDbcspell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cooldown { get; set; }
        public short? Skillline { get; set; }
        public short? Tradeskillcategory { get; set; }
        public int? Replacesspell { get; set; }
        public byte? Expansion { get; set; }
        public string Requiredside { get; set; }
    }
}
