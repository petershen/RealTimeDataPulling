using RealTimeDataPulling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealTimeDataPulling.Controllers
{
    public class DataMonitorController : Controller
    {
        // GET: DataMonitor
        public ActionResult Index()
        {
            return View(new SampleData {
                CheckPoint1 = 0.0,
                CheckPoint2 = 0.0
            });
        }
    }
}