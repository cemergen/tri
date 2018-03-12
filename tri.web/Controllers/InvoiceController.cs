using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tri.business;

namespace tri.web.Controllers
{
    public class InvoiceController : Controller
    {
        InvoiceBusiness ib;

        public InvoiceController()
        {
            ib = new InvoiceBusiness();
        }
        public ActionResult Index()
        {
            var retData = ib.GetInvoiceInfos();
            return View(retData);
        }
    }
}