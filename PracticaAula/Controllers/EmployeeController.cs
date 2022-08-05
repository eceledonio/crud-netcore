using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticaAula.Data;
using PracticaAula.Models;
using System.Linq;

namespace PracticaAula.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;

        }

        // GET: Employee
        public ActionResult Index()
        {
            var employee = _context.Employee.ToList();
            return View(employee);
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employee.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            
            return View(employee);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = _context.Employee.Find(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employee.Update(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

  
        // POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var employee = _context.Employee.Find(id);

            if (employee == null)
            {
                return NotFound();
            }
            _context.Remove(employee);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
