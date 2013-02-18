using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OFRPDMS.Models;

namespace OFRPDMS.Controllers
{ 
    public class ProgramLocationsController : Controller
    {
        private ProgramLocationDBContext db = new ProgramLocationDBContext();

        //
        // GET: /ProgramLocations/

        public ViewResult Index()
        {
            return View(db.ProgramLocations.ToList());
        }

        //
        // GET: /ProgramLocations/Details/5

        public ViewResult Details(int id)
        {
            ProgramLocation programlocation = db.ProgramLocations.Find(id);
            return View(programlocation);
        }

        //
        // GET: /ProgramLocations/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /ProgramLocations/Create

        [HttpPost]
        public ActionResult Create(ProgramLocation programlocation)
        {
            if (ModelState.IsValid)
            {
                db.ProgramLocations.Add(programlocation);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(programlocation);
        }
        
        //
        // GET: /ProgramLocations/Edit/5
 
        public ActionResult Edit(int id)
        {
            ProgramLocation programlocation = db.ProgramLocations.Find(id);
            return View(programlocation);
        }

        //
        // POST: /ProgramLocations/Edit/5

        [HttpPost]
        public ActionResult Edit(ProgramLocation programlocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(programlocation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(programlocation);
        }

        //
        // GET: /ProgramLocations/Delete/5
 
        public ActionResult Delete(int id)
        {
            ProgramLocation programlocation = db.ProgramLocations.Find(id);
            return View(programlocation);
        }

        //
        // POST: /ProgramLocations/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            ProgramLocation programlocation = db.ProgramLocations.Find(id);
            db.ProgramLocations.Remove(programlocation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}