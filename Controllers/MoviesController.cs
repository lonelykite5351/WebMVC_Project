using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lonelykite.Models;    // 要加這行
using lonelykite.ViewModels;

namespace lonelykite.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "lonely" };
            var customer = new List<Customer>
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customer
            };

            return View(viewModel);
            //return Content("This is return content");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page=1, sortBy  = "name"});
        }

        public ActionResult Edit(int id)
        {
            //URL:https://localhost:44378/movies/Edit/1
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}  sortBy={1}", pageIndex, sortBy));
            //Movies導向URL：https://localhost:44378/Movies 顯示為：pageIndex=1  sortBy=Name
            //動態更新網址：https://localhost:44378/Movies?pageIndex=4&sortBy=rrrrrr  顯示為：pageIndex=4  sortBy=rrrrrr
        }

        //呼叫MapMvcAttributeRoutes方法後，加入這行定義URL格式，下面的ByReleaseDate保留
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]

        //自訂URL，在RouteConfig.cs裡面
        public ActionResult ByReleaseDate(int year, int month)
        {
            //範例：https://localhost:44378/Movies/released/2019/8
            return Content(year + "/" + month );
        }
    }
}