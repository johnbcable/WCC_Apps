using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WCCCustomerServiceDataMvc.Models;
using WCC.Shared;

namespace WCCCustomerServiceDataMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private WCCCustomerServiceData db;

        public HomeController(ILogger<HomeController> logger, WCCCustomerServiceData injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel 
            {
                udv_LastYearsSignpostingSummarys = db.udv_LastYearsSignpostingSummarys.ToList()
            };
            return View(model);      // pass model to the view
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
