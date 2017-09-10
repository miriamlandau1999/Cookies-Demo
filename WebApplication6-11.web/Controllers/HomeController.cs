using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6_11.web.Models;

namespace WebApplication6_11.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexViewModel iv = new IndexViewModel();
            HttpCookie cookie = Request.Cookies["IncrementNumber"];
            if (cookie == null)
            {
                iv.Number = 1;
            }
            else
            {
                iv.Number = int.Parse(cookie.Value) + 1;
            }
            

            HttpCookie IncrementNumber = new HttpCookie("IncrementNumber", iv.Number.ToString());
            Response.Cookies.Add(IncrementNumber);
            
            return View(iv);
        }

      
      
    }
}