using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.LocaitonCommands
{
    public class CreateLocaitonCommand : IRequest
    {
        public string Name { get; set; }
    }
}
