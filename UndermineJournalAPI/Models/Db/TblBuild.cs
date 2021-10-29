using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblBuild
    {
        public int Build { get; set; }
        public byte[] Files { get; set; }
    }
}
