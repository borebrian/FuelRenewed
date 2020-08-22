using Fuela.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fuela.DBContext
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Station_Owners> Station_owners { get; set; }
        public DbSet<Station_reg> Station_reg { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
           : base(options) {
        
        }
    }
}
