using FinekraCase.Application.Commons.Mapping;

namespace FinekraCase.Application.Features.Perfumes.Queries.GetFilterPerfumes
{
    public class PerfumesDto : IMapFrom<FinekraCase.Domain.Entities.Perfumes>
    {
        public Guid Id { get; set; }
        public string PerfumeName { get; set; }
        public decimal Price { get; set; }
        public string BrandName { get; set; }
    }
}
