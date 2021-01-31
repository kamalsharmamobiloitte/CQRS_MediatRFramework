using MediatR;
using MediatRPattern.DbModels;
using MediatRPattern.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRPattern.Handlers
{
    public class GetAllWorkshopHandler : IRequestHandler<GetAllWorkshopQuery, List<Workshop>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllWorkshopHandler(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Workshop>> Handle(GetAllWorkshopQuery request, CancellationToken cancellationToken)
        {
            var result = await Task.Run(() =>
            {
                return _context.Workshops.ToList();
            });

            return result;
        }
    }
}
