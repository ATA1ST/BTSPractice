using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{

    public class WorkTask
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