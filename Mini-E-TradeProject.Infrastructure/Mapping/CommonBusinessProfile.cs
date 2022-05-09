using AutoMapper;
using Mini_E_TradeProject.Domain.Entities.Common;
using Mini_E_TradeProject.Infrastructure.Models;

namespace Mini_E_TradeProject.Infrastructure.Mapping
{
    public class CommonBusinessProfile : Profile
    {
        public CommonBusinessProfile()
        {
            #region Business => Entity

            CreateMap<BaseModel, BaseEntity>()
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.CreatedDate, opt => opt.MapFrom(src => src.Created))
                .ForMember(dst => dst.UpdatedDate, opt => opt.MapFrom(src => src.Updated));

            #endregion

            #region Entity => Business

            CreateMap<BaseEntity, BaseModel>()
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Created, opt => opt.MapFrom(src => src.CreatedDate))
                .ForMember(dst => dst.Updated, opt => opt.MapFrom(src => src.UpdatedDate));

            #endregion

        }
    }
}