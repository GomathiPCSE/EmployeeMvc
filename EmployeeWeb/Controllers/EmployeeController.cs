using Employee.Entity;
using Employee.DAL;
using System.Collections.Generic;

using System.Web;
using System.Web.Mvc;

namespace EmployeeWeb.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<EmployeeEntity> employee = EmployeeRepository.GetDetails();
            return View(employee);
        }
        public ActionResult DataPassing()
        {
            IEnumerable<EmployeeEntity> employee = EmployeeRepository.GetDetails();
            ViewBag.Employees = employee;
            ViewData["employee"] = employee;
            TempData["employee"] = employee;
            return View(employee);
        }
        public ActionResult Display()
        {
            return View();
        }
    }
}