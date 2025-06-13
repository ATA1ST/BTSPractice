using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Core.Models;

namespace Application.WorkTasks.Commands.CreateWorkTask
{
    public record CreateWorkTaskCommand(
        int CrewId,  int ShiftId, Status Status, decimal PlannedQuantity, decimal ActualQuantity, int MaterialId,
        decimal UsedMaterialQuantity
    ) : IRequest<int>;
}