using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContextFactory : IDesignTimeDbContextFactory<DevFreelaDbContext>
    {
        public DevFreelaDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DevFreelaDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DevFreela;Trusted_Connection=True;");
            return new DevFreelaDbContext(optionsBuilder.Options);
        }
    }
}
