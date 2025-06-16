using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Dtos;
using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class CrewRepository : ICrewRepository
    {
        public ApplicationDBContext _context;
        public CrewRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public Task<Crew> CreateAsync(Crew crewModel)
        {
            return null;       
        }

        public Task<Crew?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Crew>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Crew?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Crew?> UpdateAsync(int id, UpdateCrewDto crewDto)
        {
            throw new NotImplementedException();
        }
    }
}