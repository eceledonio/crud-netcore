using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PracticaAula.Data;
using PracticaAula.Models;
using System.Linq;

namespace PracticaAula.Controllers
{
    public class VacationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VacationsController(ApplicationDbContext context)
        {
            _context = context;

        }
        // GET: VacationsController
        public ActionResult Index()
        {
            var vacations = _context.Vacations.ToList();
            return View(vacations);
        }


        // GET: VacationsController/Create
        public ActionResult Create()
        {
            ViewData["Employee"] = new SelectList(_context.Employee.ToList(), "Id", "FullName");
            return View();
        }

        // POST: VacationsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vacations vacations)
        {
            if (ModelState.IsValid)
            {
                _context.Vacations.Add(vacations);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewData["Employee"] = new SelectList(_context.Employee.ToList(), "Id", "FullName");
            return View(vacations);
        }

        // GET: VacationsController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewData["Employee"] = new SelectList(_context.Employee.ToList(), "Id", "FullName");

            var vacations = _context.Vacations.Find(id);

            if (vacations == null)
            {
                return NotFound();
            }

            return View(vacations);
        }

        // POST: VacationsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Vacations vacations)
        {
            if (ModelState.IsValid)
            {
                _context.Vacations.Update(vacations);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewData["Employee"] = new SelectList(_context.Employee.ToList(), "Id", "FullName");
            return View(vacations);
        }

     

        // POST: VacationsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var vacations = _context.Vacations.Find(id);

            if (vacations == null)
            {
                return NotFound();
            }
            _context.Remove(vacations);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
