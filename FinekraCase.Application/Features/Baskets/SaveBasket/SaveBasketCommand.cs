using FinekraCase.Application.Commons.Mapping;
using FinekraCase.Domain.Entities;
using MediatR;

namespace FinekraCase.Application.Features.Baskets.SaveBasket
{
    public class SaveBasketCommand : IRequest, IMapFrom<FinekraCase.Domain.Entities.Baskets>
    {
        public Guid UserDetailId { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public Guid PerfumeId { get; set; }
    }
    public class SaveBasketCommandCommandHandler : IRequestHandler<SaveBasketCommand>
    {
        private readonly IGenericRepository<FinekraCase.Domain.Entities.Baskets> _basketRepository;
        private readonly IGenericRepository<UserDetails> _userRepository;

        public SaveBasketCommandCommandHandler(IGenericRepository<FinekraCase.Domain.Entities.Baskets> basketRepository,
                                               IGenericRepository<UserDetails> userRepository)
        {
            _basketRepository = basketRepository;
            _userRepository = userRepository;
        }
        public async Task<Unit> Handle(SaveBasketCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserDetailId);
            if (user is null)
            {
                throw new Exception("User bulunamadı");
            }

            //await _basketRepository.SaveAsync(request);

            return Unit.Value;
        }
    }
}