using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NIPWebAppBase.Data;
using NIPWebAppBase.Entities;
using NIPWebAppBase.Providers;

namespace NIPWebAppMVC.Controllers
{
    public class CompaniesController : Controller
    {
        private NIPContext db = new NIPContext();

        public async Task<ActionResult> Details(string valueToFind)
        {            
            var companyDto = CompaniesProvider.GetCompany(valueToFind, Request.Headers);
            ViewBag.SearchKey = valueToFind;
            return View(await companyDto);
        }
    }
}
