﻿using CasgemMediator.MediatorPattern.Result;
using MediatR;

namespace CasgemMediator.MediatorPattern.Queries
{
    public class GetProductQuery : IRequest<List<GetProductQueryResult>>
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
