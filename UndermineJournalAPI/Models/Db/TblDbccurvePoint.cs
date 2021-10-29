using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblDbccurvePoint
    {
        public short Curve { get; set; }
        public byte Step { get; set; }
        public float Key { get; set; }
        public float Value { get; set; }
    }
}
