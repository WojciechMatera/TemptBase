using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemptBase.Domain.Abstract;
using TemptBase.Domain.Entities;

namespace TemptBase.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IParametrRepository repository;

        public AdminController(IParametrRepository repo)
        {
            repository = repo;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View(repository.Parametrs);
        }

        public ViewResult Edit(int parametrID)
        {
            Parametr parametr = repository.Parametrs
                .FirstOrDefault(p => p.ParametrID == parametrID);
            return View(parametr);
        }

        [HttpPost]
        public ActionResult Edit(Parametr parametr)
        {
            if (ModelState.IsValid)
            {
                repository.SaveParametr(parametr);
                TempData["message"] = string.Format("Zapisano {0} ", parametr.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // błąd w wartościach danych
                return View(parametr);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Parametr());
        }

        [HttpPost]
        public ActionResult Delete(int parametrId)
        {
            Parametr deletedParametr = repository.DeleteParametr(parametrId);
            if (deletedParametr != null)
            {
                TempData["message"] = string.Format("Usunięto {0}",
                    deletedParametr.Name);
            }
            return RedirectToAction("Index");
        }
    }
}