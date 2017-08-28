using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4_1._0
{
    public class helloworldController : Controller
    {
        //
        // GET: /helloworld/
         
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        public string Welcome(string name,string password)
        {
            return HttpUtility.HtmlEncode("name: "+name+"password: "+password);
        }

        public ActionResult IndexView(string name, string password) 
        {
            ViewBag.Message = "name" + name;
            ViewBag.Password = password;
            return View();
        }

    }
}
