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
            //Item
            CreateMap<TblDbcitem, ItemDTO>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id))
                // tu będzie conditional zależny od locale
                // np. .ForMember(dest => dest.IsAdult, opt => opt.MapFrom(src => src.Age > 18 ? true : false));

                .ForMember(dest => dest.item_name, opt => opt.MapFrom(src => src.NameEnus))
                .ForMember(dest => dest.class_id, opt => opt.MapFrom(src => src.Class))
                .ForMember(dest => dest.subclass_id, opt => opt.MapFrom(src => src.Subclass))
                .ForMember(dest => dest.image_url, opt => opt.MapFrom(src => $"https://wow.zamimg.com/images/wow/icons/large/{src.Icon}.jpg"))
                .ForMember(dest => dest.vendor_buy_price, opt => opt.MapFrom(src => src.Buyfromvendor))
                .ForMember(dest => dest.vendor_sell_price, opt => opt.MapFrom(src => src.Selltovendor))
                .ForMember(dest => dest.required_level, opt => opt.MapFrom(src => src.Requiredlevel))
                .ForMember(dest => dest.required_skill, opt => opt.MapFrom(src => src.Requiredskill))
                .ForMember(dest => dest.required_side, opt => opt.MapFrom(src => src.Requiredside))
                .ForMember(dest => dest.other_side_item, opt => opt.MapFrom(src => src.Othersideitem))
                .ForMember(dest => dest.stack_size, opt => opt.MapFrom(src => src.Stacksize))
                .ForMember(dest => dest.auctionable, opt => opt.MapFrom(src => src.Auctionable == 0 ? true : false))
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id));

            // Item daily history
            CreateMap<TblItemHistoryDaily, ItemHistoryDailyDTO>()
                .ForMember(dest => dest.itemId, opt => opt.MapFrom(src => src.Item))
                .ForMember(dest => dest.realmId, opt => opt.MapFrom(src => src.House))
                .ForMember(dest => dest.date, opt => opt.MapFrom(src => src.When))
                .ForMember(dest => dest.price_min, opt => opt.MapFrom(src => src.Pricemin))
                .ForMember(dest => dest.price_avg, opt => opt.MapFrom(src => src.Priceavg))
                .ForMember(dest => dest.price_max, opt => opt.MapFrom(src => src.Pricemax))
                .ForMember(dest => dest.price_start, opt => opt.MapFrom(src => src.Pricestart))
                .ForMember(dest => dest.price_end, opt => opt.MapFrom(src => src.Priceend))
                .ForMember(dest => dest.quantity_min, opt => opt.MapFrom(src => src.Quantitymin))
                .ForMember(dest => dest.quantity_max, opt => opt.MapFrom(src => src.Quantitymax))
                .ForMember(dest => dest.quantity_avg, opt => opt.MapFrom(src => src.Quantityavg));

        }
    }
}
