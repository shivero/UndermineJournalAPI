using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UndermineJournalAPI.Models.Db;
using UndermineJournalAPI.Models.Data;
namespace UndermineJournalAPI.Mappings
{
    public class MapingProfile : Profile
    {
        public MapingProfile()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.SourceMemberNamingConvention = new PascalCaseNamingConvention();
                cfg.DestinationMemberNamingConvention = new LowerUnderscoreNamingConvention();
            });

            //Item
            CreateMap<TblDbcitem, ItemDTO>();

            // Item daily history
            CreateMap<TblItemHistoryDaily, ItemHistoryDailyDTO>();
            // Realm search
            CreateMap<TblRealm, RealmDTO>();
        }
    }
}
