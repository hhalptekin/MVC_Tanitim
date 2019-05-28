using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tanitim.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Category()
        {
            return View();

        }

        public ActionResult Popular()
        {
            return View();
        }

        public ActionResult Tag()
        {
            return View();
        }
        public ActionResult Detail()
        {
            return View();
        }

    }
}