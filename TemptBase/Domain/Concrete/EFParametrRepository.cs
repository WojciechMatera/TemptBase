using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemptBase.Domain.Abstract;
using TemptBase.Domain.Entities;

namespace TemptBase.Domain.Concrete
{
    public class EFParametrRepository : IParametrRepository 
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Parametr> Parametrs
        {
            get { return context.Parametrs; }
        }
    }
}
