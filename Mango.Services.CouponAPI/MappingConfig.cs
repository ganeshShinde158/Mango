using AutoMapper;
using Mango.Services.CouponAPI.Models;
using Mango.Services.CouponAPI.Models.Dto;

namespace Mango.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(congif =>
            {
                congif.CreateMap<CouponDto, Coupon>();
                congif.CreateMap<Coupon, CouponDto>();

            });
            return mappingConfig;
        }
    }
}
