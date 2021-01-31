using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRPattern.Commands
{
    public class CreateWorkshopCommand : IRequest<string>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
