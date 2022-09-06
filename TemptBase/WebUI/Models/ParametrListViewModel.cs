using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TemptBase.Domain.Entities;

namespace TemptBase.WebUI.Models
{
    public class ParametrListViewModel
    {
        public IEnumerable<Parametr> Parametrs { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}