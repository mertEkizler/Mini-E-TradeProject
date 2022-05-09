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

            CreateMap<CustomerModel, Customer>()
                .IncludeBase<BaseModel, BaseEntity>()
                .ForMember(dst => dst.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dst => dst.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name));

            #endregion

            #region Entity => Business

            CreateMap<Customer, CustomerModel>()
                .IncludeBase<BaseEntity, BaseModel>()
                .ForMember(dst => dst.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dst => dst.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name));

            #endregion
        }
    }
}