using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Models;
using Microsoft.Extensions.Configuration;
using Core.Interfaces;


namespace Infrastructure.Data
{
    public class ApplicationDBContext : DbContext, IApplicationDBContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<WorkTask> Tasks { get; set; }
    }
}