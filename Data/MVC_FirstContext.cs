using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_First.Models;

namespace MVC_First.Data
{
    public class MVC_FirstContext : DbContext
    {
        public MVC_FirstContext (DbContextOptions<MVC_FirstContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_First.Models.Employee> Employee { get; set; } = default!;
    }
}
