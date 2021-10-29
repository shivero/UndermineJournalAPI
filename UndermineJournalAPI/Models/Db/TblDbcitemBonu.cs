using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblDbcitemBonu
    {
        public short Id { get; set; }
        public byte? Quality { get; set; }
        public short? Level { get; set; }
        public short? Previewlevel { get; set; }
        public short? Levelcurve { get; set; }
        public int? Levelcurvepriority { get; set; }
        public byte? Requiredlevel { get; set; }
        public int? Tagid { get; set; }
        public byte? Tagpriority { get; set; }
        public int? Nameid { get; set; }
        public byte? Namepriority { get; set; }
        public ulong? Socketmask { get; set; }
    }
}
