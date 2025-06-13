using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Models;

namespace Core.Interfaces
{
    public interface IApplicationDBContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<WorkTask> Tasks { get; }
    }
}