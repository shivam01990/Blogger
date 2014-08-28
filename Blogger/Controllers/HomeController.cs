using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;
using Blogger.Models;
using PagedList;


namespace Blogger.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? page)
        {
            List<tbl_Post> lstPost = new List<tbl_Post>();
            lstPost = PostProvider.GetAllPost();
            List<PostModel> Model = (from p in lstPost select new PostModel { Id = p.Id, ContentMsg = p.ContentMsg, Title = p.Title, UpdatedBy = p.UpdatedBy }).ToList();
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(Model.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
