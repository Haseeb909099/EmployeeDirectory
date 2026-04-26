using EmployeeDirectory.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDirectory.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // LIST + FILTER
        public IActionResult Index(string department)
        {
            var employees = _context.Employees.AsQueryable();

            if (!string.IsNullOrEmpty(department))
            {
                employees = employees.Where(e => e.Department == department);
            }

            return View(employees.ToList());
        }

        // DETAILS PAGE
        public IActionResult Details(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }
    }
}