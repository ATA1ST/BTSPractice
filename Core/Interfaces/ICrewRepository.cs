using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Dtos;
using Core.Models;

namespace Core.Interfaces
{
    public interface ICrewRepository
    {
        Task<List<Crew>> GetAllAsync();
        Task<Crew?> GetByIdAsync(int id);
        Task<Crew> CreateAsync(Crew crewModel);
        Task<Crew?> UpdateAsync(int id, UpdateCrewDto crewDto);
        Task<Crew?> DeleteAsync(int id);
    }
}