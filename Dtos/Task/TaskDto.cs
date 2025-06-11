using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Dtos.Task
{
    public class WorkTaskDto
    {
        public int Id { get; set; }
        public int CrewId { get; set; }
        public int ShiftId { get; set; }
        public Status Status { get; set; }
        public decimal PlannedQuantity { get; set; }
        public decimal ActualQuantity { get; set; }
        public int MaterialId { get; set; }
        public decimal UsedMaterialQuantity { get; set; }
    }
}