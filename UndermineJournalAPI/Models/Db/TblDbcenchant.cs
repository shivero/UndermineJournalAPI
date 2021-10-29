using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblDbcenchant
    {
        public int Id { get; set; }
        public string Effect { get; set; }
        public int? Gem { get; set; }
    }
}
