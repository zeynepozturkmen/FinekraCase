using AutoMapper;
using FinekraCase.Application.Commons.Mapping;
using FinekraCase.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FinekraCase.Application.Features.Order.SaveOrder
{
    public class SaveOrderCommand : IRequest, IMapFrom<Orders>
    {
        public Guid UserDetailId { get; set; }
        public string ShipAddress { get; set; }
    }
    public class SaveOrderCommandCommandHandler : IRequestHandler<SaveOrderCommand>
    {
        private readonly IGenericRepository<FinekraCase.Domain.Entities.Baskets> _basketRepository;
        private readonly IGenericRepository<UserDetails> _userRepository;
        private readonly IGenericRepository<Orders> _orderRepository;
        private readonly IMapper _mapper;

        public SaveOrderCommandCommandHandler(IGenericRepository<FinekraCase.Domain.Entities.Baskets> basketRepository,
                                               IGenericRepository<UserDetails> userRepository,
                                               IGenericRepository<Orders> orderRepository,
                                               IMapper mapper)
        {
            _basketRepository = basketRepository;
            _userRepository = userRepository;
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(SaveOrderCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserDetailId);
            if (user is null)
            {
                throw new Exception("User is not found");
            }


            var baskets =await _basketRepository.GetAll().Where(x => x.UserDetailId == request.UserDetailId).ToListAsync();

            if (baskets.Any())
            {
                var order = new Orders()
                {
                    ShipAddress = request.ShipAddress,
                    OrderDate = DateTime.UtcNow,
                    UserDetailId = request.UserDetailId,
                    CreatedBy = user.UserName
                };
                foreach (var item in baskets)
                {
                    order.OrderDetails.Add(new OrderDetails()
                    {
                        PerfumeId = item.PerfumeId,
                        OrderId = order.Id,
                        Count = item.Count,
                        CreatedBy = user.UserName,
                        Price=item.Price
                    });
                }


                await _orderRepository.AddAsync(order);
                await _basketRepository.RemoveRangeAsync(baskets);

            }


            return Unit.Value;
        }
    }
}