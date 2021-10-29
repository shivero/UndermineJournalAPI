using System;
using System.Collections.Generic;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class TblDbctradeSkillCategory
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public short Parent { get; set; }
        public short Skillline { get; set; }
        public short Order { get; set; }
    }
}
