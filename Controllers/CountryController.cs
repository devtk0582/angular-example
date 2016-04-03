using AngularExample.Models.Repository;
using AngularExample.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularExample.Controllers
{
    public class CountryController : Controller
    {
        ICountryRepository _repository;

        public CountryController()
        {
            _repository = new CountryRepository();
        }

        public CountryController(ICountryRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCountries()
        {
            return Json(_repository.GetCountries().Select(o => new CountryViewModel()
                {
                    Id = o.CountryID,
                    CountryName = o.CountryName,
                    CountryCode = o.CountryCode,
                    ISO3Code = o.ISO3Code,
                    ImageName = o.ImageName ?? "default.jpg"
                }), JsonRequestBehavior.AllowGet);
        }

    }
}
