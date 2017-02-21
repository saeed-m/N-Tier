using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DNTBreadCrumb;

namespace UI.WEB.Controllers
{
    [BreadCrumb(Title = "داشبورد", UseDefaultRouteUrl = true, RemoveAllDefaultRouteValues = true,
       Order = 0, GlyphIcon = "fa fa-link")]
    public class HomeController : Controller
    {
        
        [BreadCrumb(Title = "ایندکس", Order = 1, GlyphIcon = "fa fa-bars")]
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}