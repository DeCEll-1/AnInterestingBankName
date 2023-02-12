using AnInterestingBankName.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnInterestingBankName.Controllers
{
    public class HomeController : Controller
    {
        AnInterestingBankName_Model db = new AnInterestingBankName_Model();
        // GET: Home
        public ActionResult Index()
        {

            return View(db.Logs.ToList());
        }
    }
}