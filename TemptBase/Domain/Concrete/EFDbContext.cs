using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemptBase.Domain.Entities;
using System.Data.Entity;

namespace TemptBase.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Parametr> Parametrs { get; set; }
    }
}
