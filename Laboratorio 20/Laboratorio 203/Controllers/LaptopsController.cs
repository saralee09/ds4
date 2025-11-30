using System.Linq;
using System.Web.Mvc;
using Laboratorio203.Models;

namespace Laboratorio203.Controllers
{
    public class LaptopsController : Controller
    {
        private readonly AppDbContext db = new AppDbContext();

        // GET: Laptops
        public ActionResult Index()
        {
            return View(db.Laptops.ToList());
        }

        // GET: Laptops/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Laptops/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Laptop laptop)
        {
            if (ModelState.IsValid)
            {
                db.Laptops.Add(laptop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(laptop);
        }

        // GET: Laptops/Edit/5
        public ActionResult Edit(int id)
        {
            var laptop = db.Laptops.Find(id);
            if (laptop == null) return HttpNotFound();
            return View(laptop);
        }

        // POST: Laptops/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Laptop laptop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(laptop).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(laptop);
        }

        // GET: Laptops/Delete/5
        public ActionResult Delete(int id)
        {
            var laptop = db.Laptops.Find(id);
            if (laptop == null) return HttpNotFound();
            return View(laptop);
        }

        // POST: Laptops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var laptop = db.Laptops.Find(id);
            db.Laptops.Remove(laptop);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Laptops/Details/5
        public ActionResult Details(int id)
        {
            var laptop = db.Laptops.Find(id);
            if (laptop == null) return HttpNotFound();
            return View(laptop);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}