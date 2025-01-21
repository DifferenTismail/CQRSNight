using CQRSNight.Context;
using CQRSNight.CQRSDesignPattern.Results.ProductResults;
using Microsoft.EntityFrameworkCore;

namespace CQRSNight.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class GetProductQueryHandler
    {
        private readonly CQRSContext _context;

        public GetProductQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task<List<GetProductQueryResult>> Handle()
        {
            var values = await _context.Products.ToListAsync();
            return values.Select(x => new GetProductQueryResult 
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                ProductStok = x.ProductStok,
            }).ToList();
        }
    }
}
