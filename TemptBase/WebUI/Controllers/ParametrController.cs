using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemptBase.Domain.Abstract;
using TemptBase.Domain.Entities;

namespace TemptBase.WebUI.Controllers
{
    public class ParametrController : Controller
    {
        private IParametrRepository repository;

        public ParametrController(IParametrRepository parametrRepository)
        {
            this.repository = parametrRepository;
        }
        // GET: Parametr
        public ViewResult List()
        {
            return View(repository.Parametry);
        }
    }
}