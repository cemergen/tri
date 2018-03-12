using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tri.business;

namespace tri.web.Controllers
{
    public class AccountController : Controller
    {
        AccountBusiness ab;

        public AccountController()
        {
            ab = new AccountBusiness();
        }
        public ActionResult Index()
        {
            return View(ab.GetAccountInfoes());
        }
    }
}