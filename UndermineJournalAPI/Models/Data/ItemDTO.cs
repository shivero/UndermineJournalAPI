using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UndermineJournalAPI.Models.Data
{
    public class ItemDTO
    {
        public int id { get; set; }
        public string item_name { get; set; }
        public int quality { get; set; }
        public int level { get; set; }

        public int class_id { get; set; }
        public int subclass_id { get; set; }
        public int image_url { get; set; }
        public int vendor_buy_price { get; set; }
        public int vendor_sell_price { get; set; }
        public bool auctionable { get; set; }
        public int type { get; set; }
        public int required_level { get; set; }

        public int required_skill { get; set; }
        public string required_side { get; set; }
        public int? display { get; set; }
        public int other_side_item { get; set; }


    }
}
