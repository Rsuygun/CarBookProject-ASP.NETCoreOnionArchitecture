using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.LocaitonCommands
{
    public class RemoveLocaitonCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveLocaitonCommand(int id)
        {
            Id = id;
        }
    }
}
