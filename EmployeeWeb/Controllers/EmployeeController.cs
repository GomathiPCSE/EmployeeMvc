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
            return RedirectToAction("Display");
        }
        public ActionResult Display()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeEntity employee)
        {
            EmployeeRepository.Add(employee);
            TempData["Result"] = "Added Successfully";
            return RedirectToAction("DataPassing");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeEntity employee = EmployeeRepository.GetEmployeeById(id);
            return View(employee);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            EmployeeRepository.Delete(id);
            TempData["Result"] = "Deleted successfully";
            return RedirectToAction("DataPassing");
        }
        [HttpPost]
        public ActionResult Update(EmployeeEntity employee)
        {
            EmployeeRepository.Update(employee);
            return RedirectToAction("DataPassing");
        }
    }
}