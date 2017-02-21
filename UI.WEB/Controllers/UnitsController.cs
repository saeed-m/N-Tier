using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DNTBreadCrumb;
using DomainClasses.Entities;
using Newtonsoft.Json;

namespace UI.WEB.Controllers
{
    [BreadCrumb(Title = "واحدها", UseDefaultRouteUrl = true, RemoveAllDefaultRouteValues = true,
       Order = 0, GlyphIcon = "fa fa-link")]
    public class UnitsController : Controller
    {
        private static readonly CarsRESTService ApiService = new CarsRESTService();
        [BreadCrumb(Title = "لیست واحدها", Order = 1, GlyphIcon = "fa fa-bars")]
        public ActionResult Index()
        {
            
        List<Organization> org = ApiService.GetOrganizations().ToList();
            return View(org);
        }

        [HttpGet]
        [BreadCrumb(Title = "افزودن واحده جدید", Order = 2, GlyphIcon = "fa fa-pencil")]
        public ActionResult AddOrg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addorg(Organization organization)
        {


            return RedirectToAction("AddOrg");
        }

        //Caling WebApi Service
        public class CarsRESTService
        {
            readonly string baseUri = "http://api.csspro.ir/api/organization/";

            public List<Organization> GetOrganizations()
            {
                string uri = baseUri;
                using (HttpClient httpClient = new HttpClient())
                {
                    Task<String> response = httpClient.GetStringAsync(uri);
                    return JsonConvert.DeserializeObjectAsync<List<Organization>>(response.Result).Result;
                }
            }
        }

    }
}