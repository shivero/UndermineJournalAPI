using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblHouseCheck
    {
        public short House { get; set; }
        public DateTime? Lastdaily { get; set; }
    }
}
