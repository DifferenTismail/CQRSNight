﻿using CQRSNight.Context;
using CQRSNight.CQRSDesignPattern.Queries.CategoryQueries;
using CQRSNight.CQRSDesignPattern.Queries.ProductQueries;
using CQRSNight.CQRSDesignPattern.Results.CategoryResults;
using CQRSNight.CQRSDesignPattern.Results.ProductResults;

namespace CQRSNight.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly CQRSContext _context;

        public GetProductByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery query)
        {
            var values = await _context.Products.FindAsync(query.ProductId);
            return new GetProductByIdQueryResult
            {
                ProductId = values.ProductId,
                ProductName = values.ProductName,
                ProductPrice = values.ProductPrice,
                ProductStok = values.ProductStok
            };
        }
    }
}
