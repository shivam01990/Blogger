using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;
using Blogger.Models;

namespace Blogger.Controllers
{
    public class PostsController : Controller
    {
        //
        // GET: /Posts/

        public ActionResult Index(int? Id)
        {
            int id = 0;
            if (Id != 0 && Id != null)
            {
                id = (int)Id;

                tbl_Post p = PostProvider.GetPost(id);
                PostModel Model = new PostModel { Id = p.Id, ContentMsg = p.ContentMsg, Title = p.Title, UpdatedBy = p.UpdatedBy };
                return View(Model);
            }
            else
                return View();
        }

        [HttpPost]
        public JsonResult SubmitComment(string commenttext)
        {
            return Json(commenttext, JsonRequestBehavior.AllowGet);
        }
        //
        // GET: /Posts/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Posts/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Posts/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Posts/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Posts/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Posts/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Posts/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
