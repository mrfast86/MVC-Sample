using EventfulSearch.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using EventfulSearchWebsite.Models;
using EventfulSearchWebsite.Mapper;

namespace EventfulSearchWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGeoCodeDomain _geoCodeDomain;
        private readonly IEventfulSearchDomain _eventfulSearchDomain;

        public HomeController(IGeoCodeDomain geoCodeDomain, IEventfulSearchDomain eventfulSearchDomain)
        {
            _geoCodeDomain = geoCodeDomain;
            _eventfulSearchDomain = eventfulSearchDomain;
        }

        public ActionResult Index()
        {
            SearchViewModel model = new SearchViewModel();
            model.StartDate = DateTime.Today;
            model.EndDate = DateTime.Today.AddDays(1);
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> SearchAsync(SearchViewModel model)
        {
            model.Location = await _geoCodeDomain.GetLocationAsync(model.Address);
            model.SearchResults = await _eventfulSearchDomain.SearchAsync(model.MapTo());

            return View("Index", model);
        }
    }
}