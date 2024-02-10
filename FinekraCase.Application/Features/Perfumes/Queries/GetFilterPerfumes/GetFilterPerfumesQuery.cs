using AutoMapper;
using FinekraCase.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FinekraCase.Application.Features.Perfumes.Queries.GetFilterPerfumes
{
    public class GetFilterPerfumesQuery : IRequest<List<PerfumesDto>>
    {

    }

    public class GetFilterPerfumesQueryHandler : IRequestHandler<GetFilterPerfumesQuery, List<PerfumesDto>>
    {
        private readonly IGenericRepository<FinekraCase.Domain.Entities.Perfumes> _perfumeRepository;
        private readonly IMapper _mapper;

        public GetFilterPerfumesQueryHandler(IGenericRepository<FinekraCase.Domain.Entities.Perfumes> perfumeRepository,
                                            IMapper mapper)
        {
            _perfumeRepository = perfumeRepository;
            _mapper = mapper;
        }
        public async Task<List<PerfumesDto>> Handle(GetFilterPerfumesQuery request, CancellationToken cancellationToken)
        {
            var perfumes = _perfumeRepository.GetAll().Include(x=>x.Brand).Where(x => x.RecordStatus == RecordStatus.Active);

            var perfumesResponseList = _mapper.Map<List<PerfumesDto>>(perfumes);

            return perfumesResponseList;
        }
    }
}