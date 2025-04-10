using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using appRH.Models;

namespace appRH.Data
{
    public class appRHContext : DbContext
    {
        public appRHContext (DbContextOptions<appRHContext> options)
            : base(options)
        {
        }

        public DbSet<appRH.Models.Employee> Employee { get; set; } = default!;
    }
}
