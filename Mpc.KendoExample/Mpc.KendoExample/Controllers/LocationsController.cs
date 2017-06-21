﻿using System.Collections.Generic;
using System.Web.Mvc;

namespace Mpc.KendoExample.Controllers
{
    public class LocationsController : Controller
    {
        // GET: Locations
        [HttpGet]
        public JsonResult Sitesdropdowntest()
        {
            //var sites = _context.v_dim_HMLocations.Select(l => new
            //{
            //    Id = l.Id,
            //    SiteName = l.site
            //});
            var sites = new List<object>
            {
                new { Id = 1, SiteName = "Site1" },
                new { Id = 2, SiteName = "Site2" },
                new { Id = 3, SiteName = "Site3" },
                new { Id = 4, SiteName = "Site4" },
                new { Id = 5, SiteName = "Site5" }
            };

            return Json(sites, JsonRequestBehavior.AllowGet);
        }
    }
}