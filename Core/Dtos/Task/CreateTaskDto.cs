using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Core.Dtos.Task
{
    public class CreateWorkTaskDto
    {
        [Required]
        public int CrewId { get; set; }

        [Required]
        public int ShiftId { get; set; }

        [Required]
        public Status Status { get; set; }

        [Range(0, double.MaxValue)]
        public decimal PlannedQuantity { get; set; }

        public decimal ActualQuantity { get; set; } = 0; 

        [Required]
        public int MaterialId { get; set; }

        public decimal UsedMaterialQuantity { get; set; } = 0;
    }
}