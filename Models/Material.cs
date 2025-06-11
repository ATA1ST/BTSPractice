using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Material
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public WeightUnit Unit { get; set; }
    }
}