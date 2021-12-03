using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UndermineJournalAPI.Models.Data
{
    public class RealmDTO
    {
        public short Id { get; set; }
        public string Region { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Locale { get; set; }
        public int? House { get; set; }
        public string Canonical { get; set; }
        public string Owner_realm { get; set; }
        public int? Population { get; set; }
        public int? Blizz_Id { get; set; }
        public int? Blizz_Connection { get; set; }
    }
}
