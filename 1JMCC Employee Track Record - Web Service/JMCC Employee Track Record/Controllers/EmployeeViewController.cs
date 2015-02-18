using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMCC_Employee_Track_Record.Controllers
{
    public class EmployeeViewController : Controller
    {
        private EmployeeEntities db = new EmployeeEntities();

        //
        // GET: /EmployeeView/

        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        //
        // GET: /EmployeeView/Details/5

        public ActionResult Details(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // GET: /EmployeeView/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /EmployeeView/Create

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        //
        // GET: /EmployeeView/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /EmployeeView/Edit/5

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        //
        // GET: /EmployeeView/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /EmployeeView/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
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