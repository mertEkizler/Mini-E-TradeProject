using AutoMapper;
using Mini_E_TradeProject.Domain.Entities.Common;
using Mini_E_TradeProject.Domain.Entities.Concrete;
using Mini_E_TradeProject.Infrastructure.Models;

namespace Mini_E_TradeProject.Infrastructure.Mapping
{
    public class ProductBusinessProfile : Profile
    {
        public ProductBusinessProfile()
        {
            #region Business => Entity

            CreateMap<ProductModel, Product>()
                .IncludeBase<BaseModel, BaseEntity>()
                .ForMember(dst => dst.Stock, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dst => dst.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dst => dst.Id, opt => opt.Ignore())
                .ForMember(dst => dst.UpdatedDate, opt => opt.Ignore())
                .ForMember(dst => dst.CreatedDate, opt => opt.Ignore())
                .ForMember(dst => dst.Orders, opt => opt.Ignore());

            #endregion

            #region Entity => Business

            CreateMap<Product, ProductModel>()
                .IncludeBase<BaseEntity, BaseModel>()
                .ForMember(dst => dst.Stock, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dst => dst.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dst => dst.Id, opt => opt.Ignore())
                .ForMember(dst => dst.Updated, opt => opt.Ignore())
                .ForMember(dst => dst.Created, opt => opt.Ignore());

            #endregion
        }
    }
}