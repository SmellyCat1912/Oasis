using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Oasis.Models;

namespace Oasis.Controllers
{
    public class BoxInfoesController : Controller
    {
        private FunctionModels db = new FunctionModels();

        // GET: BoxInfoes
        public ActionResult Index()
        {
            return View(db.BoxInfoes.ToList());
        }

        // GET: BoxInfoes/Details/5
        public ActionResult Details(decimal id)

           
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BoxInfo boxInfo = db.BoxInfoes.Find(id);
            if (boxInfo == null)
            {
                return HttpNotFound();
            }
            return View(boxInfo);
        }

        // GET: BoxInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BoxInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "film_id,theatre_id")] BoxInfo boxInfo)
        {
            if (ModelState.IsValid)
            {
                db.BoxInfoes.Add(boxInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(boxInfo);
        }

        // GET: BoxInfoes/Edit/5

        public ActionResult Edit()
        {
            return View();
        }
        //public ActionResult Edit(decimal id)
       //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         //   }
         //   BoxInfo boxInfo = db.BoxInfoes.Find(id);
         //   if (boxInfo == null)
         //   {
        //        return HttpNotFound();
        //    }
         //   return View(boxInfo);
        //}

        // POST: BoxInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "film_id,theatre_id")] BoxInfo boxInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(boxInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(boxInfo);
        }

        // GET: BoxInfoes/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BoxInfo boxInfo = db.BoxInfoes.Find(id);
            if (boxInfo == null)
            {
                return HttpNotFound();
            }
            return View(boxInfo);
        }

        // POST: BoxInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BoxInfo boxInfo = db.BoxInfoes.Find(id);
            db.BoxInfoes.Remove(boxInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
