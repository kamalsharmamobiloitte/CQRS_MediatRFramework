using MediatR;
using MediatRPattern.DbModels;
using System.Collections.Generic;

namespace MediatRPattern.Queries
{
    public class GetAllWorkshopQuery : IRequest<List<Workshop>>
    {
    }
}
