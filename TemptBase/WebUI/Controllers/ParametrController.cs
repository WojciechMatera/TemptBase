using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemptBase.Domain.Abstract;
using TemptBase.Domain.Entities;
using TemptBase.WebUI.Models;

namespace TemptBase.WebUI.Controllers
{
    public class ParametrController : Controller
    {
        private IParametrRepository repository;
        public int PageSize = 4;
        public ParametrController(IParametrRepository parametrRepository)
        {
            this.repository = parametrRepository;
        }
        // GET: Parametr
        public ViewResult List(string category , int page = 1)
        {
            ParametrListViewModel viewModel = new ParametrListViewModel
            {
                Parametrs = repository.Parametrs
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ParametrID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Parametrs.Count()

                },
                CurrentCategory = category
            };

             return View(viewModel);
        }
    }
}