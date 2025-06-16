using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using MediatR;

namespace Application.WorkTasks.Commands.DeleteWorkTask
{
    public record DeleteWorkTaskCommand(
        int Id
    ) : IRequest<bool>;
}