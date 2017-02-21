using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using DomainClasses.Entities;
using System.Linq.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;
using DNTBreadCrumb;
using Newtonsoft.Json;

//Import the Dynamic LINQ library

namespace WebApp.Controllers
{
    public class CarsRESTService
    {
        readonly string baseUri = "http://api.csspro.ir/api/organization/";

        public List<Organization> GetCars()
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObjectAsync<List<Organization>>(response.Result).Result;
            }
        }
    }
    [BreadCrumb(Title = "واحدها", UseDefaultRouteUrl = true, RemoveAllDefaultRouteValues = true,
        Order = 0, GlyphIcon = "fa fa-link")]
    public class UnitsController : Controller
    {
        private static CarsRESTService carsService = new CarsRESTService();
        // GET: Units
        [BreadCrumb(Title = "لیست واحدها", Order = 1)]
        public ActionResult Index()
        {
            List<Organization> org = carsService.GetCars().ToList();
            return View(org);
        }

        [HttpGet]
        [BreadCrumb(Title = "افزودن واحده جدید", Order = 2)]
        public ActionResult AddOrg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addorg(Organization organization)
        {


            return RedirectToAction("AddOrg");
        }
      
    }
}