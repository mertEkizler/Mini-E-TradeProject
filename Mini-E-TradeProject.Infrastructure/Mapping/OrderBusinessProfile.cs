using AutoMapper;
using Mini_E_TradeProject.Domain.Entities.Common;
using Mini_E_TradeProject.Domain.Entities.Concrete;
using Mini_E_TradeProject.Infrastructure.Models;

namespace Mini_E_TradeProject.Infrastructure.Mapping
{
    public class OrderBusinessProfile : Profile
    {
        public OrderBusinessProfile()
        {
            #region Business => Entity

            CreateMap<OrderModel, Order>()
                .IncludeBase<BaseModel, BaseEntity>()
                .ForMember(dst => dst.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dst => dst.CustomerId, opt => opt.Ignore())
                .ForMember(dst => dst.Description, opt => opt.MapFrom(src => src.Description));

            #endregion

            #region Entity => Business

            CreateMap<Order, OrderModel>()
                .IncludeBase<BaseEntity, BaseModel>()
                .ForMember(dst => dst.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dst => dst.Address, opt => opt.MapFrom(src => src.Address));

            #endregion
        }
    }
}