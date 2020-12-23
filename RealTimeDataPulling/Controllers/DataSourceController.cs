using RealTimeDataPulling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace RealTimeDataPulling.Controllers
{
    public class DataSourceController : Controller
    {
        private readonly Random rand = new Random();

        [HttpGet]
        public JsonResult Sample()
        {
            double[] samples = { rand.NextDouble(), rand.NextDouble() };
            return Json(new { samples }, JsonRequestBehavior.AllowGet);
        }
    }
}
