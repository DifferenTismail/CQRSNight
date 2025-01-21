using CQRSNight.Context;
using CQRSNight.CQRSDesignPattern.Command.ProductCommands;

namespace CQRSNight.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateProductCommand command)
        {
            var values = await _context.Products.FindAsync(command.ProductId);
            values.ProductName = command.ProductName;
            values.ProductStok = command.ProductStok;
            values.ProductPrice = command.ProductPrice;
            await _context.SaveChangesAsync();
        }
    }
}
