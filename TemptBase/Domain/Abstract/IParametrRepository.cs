using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemptBase.Domain.Entities;

namespace TemptBase.Domain.Abstract
{
    public interface IParametrRepository
    {
        IEnumerable<Parametr> Parametrs { get; }

        void SaveParametr(Parametr parametr);

        Parametr DeleteParametr(int parametrID);
    }

    
}
