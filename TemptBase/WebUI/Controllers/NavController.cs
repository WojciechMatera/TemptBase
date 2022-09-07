using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemptBase.Domain.Abstract;

namespace TemptBase.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IParametrRepository repository;

        public NavController(IParametrRepository repo)
        {
            repository = repo;

        }
        public PartialViewResult Menu()
        {
            IEnumerable<string> categories = repository.Parametrs
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return PartialView(categories);
        }
        
    }
}