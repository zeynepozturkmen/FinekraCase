using MediatR;
using Newtonsoft.Json;
using Serilog;

namespace FinekraCase.Application.Features.Baskets.DeleteBasket
{
    public class DeleteBasketCommand : IRequest
    {
        public Guid Id { get; set; }
    }

    public class DeleteBasketCommandHandler : IRequestHandler<DeleteBasketCommand>
    {
        private readonly IGenericRepository<FinekraCase.Domain.Entities.Baskets> _basketRepository;

        public DeleteBasketCommandHandler(IGenericRepository<FinekraCase.Domain.Entities.Baskets> basketRepository)
        {
            _basketRepository = basketRepository;
        }

        public async Task<Unit> Handle(DeleteBasketCommand request, CancellationToken cancellationToken)
        {
            var basket = await _basketRepository.GetByIdAsync(request.Id);
            if (basket is null)
            {
                throw new Exception("Basket is not found");
            }


            await _basketRepository.DeleteAsync(basket);

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
