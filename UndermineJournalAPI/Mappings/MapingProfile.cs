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
            CreateMap<TblDbcitem, ItemDTO>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id))
                // tu będzie conditional zależny od locale
                // np. .ForMember(dest => dest.IsAdult, opt => opt.MapFrom(src => src.Age > 18 ? true : false));

                .ForMember(dest => dest.item_name, opt => opt.MapFrom(src => src.NameEnus))
                .ForMember(dest => dest.class_id, opt => opt.MapFrom(src => src.Class))
                .ForMember(dest => dest.subclass_id, opt => opt.MapFrom(src => src.Subclass))
                .ForMember(dest => dest.image_url, opt => opt.MapFrom(src => src.Icon))
                .ForMember(dest => dest.vendor_buy_price, opt => opt.MapFrom(src => src.Buyfromvendor))
                .ForMember(dest => dest.vendor_sell_price, opt => opt.MapFrom(src => src.Selltovendor))
                .ForMember(dest => dest.required_level, opt => opt.MapFrom(src => src.Requiredlevel))
                .ForMember(dest => dest.required_skill, opt => opt.MapFrom(src => src.Requiredskill))
                .ForMember(dest => dest.required_side, opt => opt.MapFrom(src => src.Requiredside))
                .ForMember(dest => dest.other_side_item, opt => opt.MapFrom(src => src.Othersideitem))
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id));
        

        }
    }
}
