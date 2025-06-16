using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Dtos.Crew
{
    public class CrewDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;

        public string Position { get; set; } = string.Empty;
        public int SiteId { get; set; }
    }
}