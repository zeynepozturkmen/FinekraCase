using FinekraCase.Application.Features.Perfumes.Queries.GetFilterPerfumes;
using FinekraCase.Domain.Entities;

namespace FinekraCase.Application.Commons.Mapping
{
    public interface IMapFrom<T>
    {
        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap(typeof(T), GetType()).ReverseMap();

            profile.CreateMap<Perfumes, PerfumesDto>()
            .ForMember(dest => dest.BrandName, opt => opt.MapFrom(src => src.Brand.BrandName))
            .ReverseMap();
        }

    }

}
