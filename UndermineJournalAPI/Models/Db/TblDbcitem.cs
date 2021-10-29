using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblDbcitem
    {
        public int Id { get; set; }
        public string NameEnus { get; set; }
        public string NameDede { get; set; }
        public string NameEses { get; set; }
        public string NameFrfr { get; set; }
        public string NameItit { get; set; }
        public string NamePtbr { get; set; }
        public string NameRuru { get; set; }
        public string NameKokr { get; set; }
        public string NameZhtw { get; set; }
        public byte Quality { get; set; }
        public short? Level { get; set; }
        public byte Class { get; set; }
        public byte Subclass { get; set; }
        public string Icon { get; set; }
        public short? Stacksize { get; set; }
        public byte? Binds { get; set; }
        public int? Buyfromvendor { get; set; }
        public int? Selltovendor { get; set; }
        public byte? Auctionable { get; set; }
        public byte? Type { get; set; }
        public byte? Requiredlevel { get; set; }
        public short? Requiredskill { get; set; }
        public string Requiredside { get; set; }
        public int? Display { get; set; }
        public int? Othersideitem { get; set; }
    }
}
