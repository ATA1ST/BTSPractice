using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using MediatR;

namespace Application.WorkTasks.Commands.UpdateWorkTask
{
    public record UpdateWorkTaskCommand(
        int Id, int CrewId,  int ShiftId, Status Status, decimal PlannedQuantity, decimal ActualQuantity, int MaterialId,
        decimal UsedMaterialQuantity
    ) : IRequest<bool>;
}