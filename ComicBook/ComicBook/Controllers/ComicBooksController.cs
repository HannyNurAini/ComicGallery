using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBook.Controllers
{
    public class ComicBooksController : Controller
    {
        //bikin fungsi tipe functionnya public; keluarannya string; namanya detail
        public ActionResult Detail()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }


    }
}