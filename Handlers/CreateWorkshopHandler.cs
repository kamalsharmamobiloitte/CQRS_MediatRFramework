using MediatR;
using MediatRPattern.Commands;
using MediatRPattern.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRPattern.Handlers
{
    public class CreateWorkshopHandler : IRequestHandler<CreateWorkshopCommand, string>
    {
        private readonly ApplicationDbContext _context;

        public CreateWorkshopHandler(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string> Handle(CreateWorkshopCommand request, CancellationToken cancellationToken)
        {
            var result = await Task.Run(()=>
              {
                  _context.Workshops.Add(new Workshop { Id = request.Id, Name = request.Name });
                  _context.SaveChanges();
                  return "Success";
              });

            return result;
        }
    }
}
