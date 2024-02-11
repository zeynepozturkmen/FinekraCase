using AutoMapper;
using FinekraCase.Application.Commons.Mapping;
using MediatR;
using Newtonsoft.Json;
using Serilog;

namespace FinekraCase.Application.Features.Baskets.UpdateBasket
{
    public class UpdateBasketCommand : IRequest, IMapFrom<FinekraCase.Domain.Entities.Baskets>
    {
        public Guid Id { get; set; }
        public int Count { get; set; }
    }
    public class UpdateBasketCommandCommandHandler : IRequestHandler<UpdateBasketCommand>
    {
        private readonly IGenericRepository<FinekraCase.Domain.Entities.Baskets> _basketRepository;
        private readonly IGenericRepository<FinekraCase.Domain.Entities.Perfumes> _perfumeRepository;
        private readonly IMapper _mapper;

        public UpdateBasketCommandCommandHandler(IGenericRepository<FinekraCase.Domain.Entities.Baskets> basketRepository,
                                                IGenericRepository<FinekraCase.Domain.Entities.Perfumes> perfumeRepository,
                                               IMapper mapper)
        {
            _basketRepository = basketRepository;
            _perfumeRepository = perfumeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateBasketCommand request, CancellationToken cancellationToken)
        {
            var basket = await _basketRepository.GetByIdAsync(request.Id);
            if (basket is null)
            {
                throw new Exception("Basket is not found");
            }

            if (request.Count == 0)
            {
                await _basketRepository.DeleteAsync(basket);
            }
            else
            {
                var perfume = await _perfumeRepository.GetByIdAsync(basket.PerfumeId);


                basket.Price = perfume.Price * request.Count;
                basket.Count = request.Count;
                await _basketRepository.UpdateAsync(basket);
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