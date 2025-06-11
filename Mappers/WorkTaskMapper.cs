using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Dtos.Task;
using WebApplication2.Models;

namespace WebApplication2.Mappers
{
    public static class WorkTaskMappers
    {
        public static WorkTaskDto ToWorkTaskDto(this WorkTask taskModel)
        {
            return new WorkTaskDto
            {
                Id = taskModel.Id,
                CrewId = taskModel.CrewId,
                ShiftId = taskModel.ShiftId,
                Status = taskModel.Status,
                PlannedQuantity = taskModel.PlannedQuantity,
                ActualQuantity = taskModel.ActualQuantity,
                MaterialId = taskModel.MaterialId,
                UsedMaterialQuantity = taskModel.UsedMaterialQuantity
            };
        }
        public static WorkTask ToWorkTaskFromCreateDto(this CreateWorkTaskDto workTaskDto)
        {
            return new WorkTask
            {
                CrewId = workTaskDto.CrewId,
                ShiftId = workTaskDto.ShiftId,
                Status = workTaskDto.Status,
                PlannedQuantity = workTaskDto.PlannedQuantity,
                ActualQuantity = workTaskDto.ActualQuantity,
                MaterialId = workTaskDto.MaterialId,
                UsedMaterialQuantity = workTaskDto.UsedMaterialQuantity
            };
        }
    }
}