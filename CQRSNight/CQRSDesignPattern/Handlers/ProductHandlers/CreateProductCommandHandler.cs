using CQRSNight.Context;
using CQRSNight.CQRSDesignPattern.Command.ProductCommands;
using CQRSNight.Entities;

namespace CQRSNight.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                ProductName = command.ProductName,
                ProductPrice = command.ProductPrice,
                ProductStok = command.ProductStok
            });
            await _context.SaveChangesAsync();
        }
    }
}
