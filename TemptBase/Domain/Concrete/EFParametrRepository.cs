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

        public void SaveParametr(Parametr parametr)
        {

            if (parametr.ParametrID == 0)
            {
                context.Parametrs.Add(parametr);
            }
            else
            {
                Parametr dbEntry = context.Parametrs.Find(parametr.ParametrID);
                if (dbEntry != null)
                {
                    dbEntry.Name = parametr.Name;
                    dbEntry.Value = parametr.Value;
                    dbEntry.Category = parametr.Category;
                }
            }
            context.SaveChanges();
        }

        public Parametr DeleteParametr(int ParametrID)
        {
            Parametr dbEntry = context.Parametrs.Find(ParametrID);
            if (dbEntry != null)
            {
                context.Parametrs.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}