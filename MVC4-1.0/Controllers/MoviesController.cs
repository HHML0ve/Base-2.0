using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC4_1._0.Models;


namespace MVC4_1._0.Controllers
{
    public class MoviesController : Controller
    {
        //
        // GET: /Movies/
        List<Movie> movies = new List<Movie>
       {
       new Movie(){ID=828,Title = "movie1",Price = 34.9f},
       new Movie(){ID=234,Title = "Movie2",Price=54.9f},
       new Movie(){ID=224,Title = "movie3",Price=54.9f}
       };

        public List<Movie> initData() {
            return movies;
        }

        public JsonResult getMovies() {

            var movieq = new Movie() { ID = 112, Title = "movie4", Price = 54.9f };
        
            return Json(movieq,JsonRequestBehavior.AllowGet); 
        }

        public ActionResult dateResult() {
            JsonResult JR = new JsonResult
            {
                Data = new
                {
                    
                }
            };
            return View();
        }

        public ActionResult Index()
        {
            
            System.Text.StringBuilder sbHtml = new System.Text.StringBuilder(4000);
            List<Movie> passDate = initData();
            passDate.ForEach(d => 
            {
                sbHtml.AppendLine("<div>"+d.ID+d.Price+d.Title+"</div>");
            });
            ViewBag.str = sbHtml.ToString();
            return View();
        }

    }
}
