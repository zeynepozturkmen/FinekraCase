using AutoMapper;
using FinekraCase.Application.Commons.Mapping;
using FinekraCase.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Serilog;

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
        private readonly IGenericRepository<FinekraCase.Domain.Entities.Perfumes> _perfumeRepository;
        private readonly IMapper _mapper;

        public SaveBasketCommandCommandHandler(IGenericRepository<FinekraCase.Domain.Entities.Baskets> basketRepository,
                                               IGenericRepository<UserDetails> userRepository,
                                               IGenericRepository<Domain.Entities.Perfumes> perfumeRepository,
                                               IMapper mapper)
        {
            _basketRepository = basketRepository;
            _userRepository = userRepository;
            _perfumeRepository = perfumeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(SaveBasketCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserDetailId);
            if (user is null)
            {
                throw new Exception("User is not found");
            }

            var perfume = await _perfumeRepository.GetByIdAsync(request.PerfumeId);
            if (perfume is null)
            {
                throw new Exception("Perfume is not found");
            }


            var basket = await _basketRepository.GetAll().Where(x => x.UserDetailId == request.UserDetailId
                                                                && x.PerfumeId == request.PerfumeId)
                                                    .FirstOrDefaultAsync();
            if (basket is not null)
            {
                basket.Price += perfume.Price * request.Count;
                basket.Count +=  request.Count;
                await _basketRepository.UpdateAsync(basket);
            }
            else
            {
                basket = _mapper.Map<FinekraCase.Domain.Entities.Baskets>(request);
                basket.Price = perfume.Price * request.Count;
                basket.CreatedBy = user.UserName;
                await _basketRepository.AddAsync(basket);
            }


            LogToFile(new LogEntry
            {
                Timestamp = DateTime.Now,
                EntityName = basket.GetType().Name,
                Data = JsonConvert.SerializeObject(basket)
            });

            return Unit.Value;
        }


        private void LogToFile(LogEntry logEntry)
        {
            // Serilog'un LoggerConfiguration'ını yapılandırma
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day) // Logları günlük dosyalarında saklamak için
                .CreateLogger();

            // LogEntry'yi Serilog kullanarak dosyaya yaz
            Log.Information($"Timestamp: {logEntry.Timestamp}, EntityName: {logEntry.EntityName}, Data: {logEntry.Data}");

            // Serilog'un kaynaklarını serbest bırakma
            Log.CloseAndFlush();
        }

    }
}