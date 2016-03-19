using SmartBusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITrialService _trialService;
        public HomeController(ITrialService trialServices)         
        {
            _trialService = trialServices;
        }
        public ActionResult Index()
        {
            var test = _trialService.Get();
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