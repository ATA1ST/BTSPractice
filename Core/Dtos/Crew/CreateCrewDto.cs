using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Dtos.Crew
{
    public class CreateCrewDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; } = string.Empty;

        public string Position { get; set; } = string.Empty;
        [Required]
        public int SiteId { get; set; }
    }
}