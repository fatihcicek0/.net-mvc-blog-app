using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class UrunController : Controller
    {
        // GET: DefauUrunlt
        public string Index()
        {
            return "URUN ";
        }
        public ViewResult Liste()
        {
            return View();
        }
    }
}