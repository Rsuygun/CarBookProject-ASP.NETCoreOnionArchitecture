using CarBook.Application.Features.Mediator.Results.LocaitonResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.LocaitonQueries
{
    public class GetLocaitonByIdQuery : IRequest<GetLocationByIdQueryResult>
    {
        public int Id { get; set; }

        public GetLocaitonByIdQuery(int id)
        {
            Id = id;
        }
    }
}
