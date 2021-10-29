using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblRealm
    {
        public short Id { get; set; }
        public string Region { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Locale { get; set; }
        public short? House { get; set; }
        public string Canonical { get; set; }
        public string Ownerrealm { get; set; }
        public int? Population { get; set; }
        public int? BlizzId { get; set; }
        public int? BlizzConnection { get; set; }
    }
}
