using CoreFirstCoreF.K.DropDown.Contract;
using CoreFirstCoreF.K.DropDown.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreFirstCoreF.K.DropDown.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _emp;
        public EmployeeController(IEmployee emp)
        {
            _emp = emp;
        }
        public IActionResult Index()
        {
            var employees = _emp.GetEmployees();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.cities =new SelectList(_emp.GetCities(),"city_id","city_name");
            ViewBag.departments = new SelectList(_emp.GetDepartments(), "Did", "Dname");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee empObj)
        {
            ModelState.Remove("Department");
            if (ModelState.IsValid)
            {
                bool b = _emp.addEmployee(empObj);
                if (b != false)
                {
                    TempData["insert"] = "<script>alert('Employee Added SuccessFully!!')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["insert"] = "<script>alert('Employee Failed!!')</script>";
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error in Employee Model!!");
            }
            return View();
        }
        [HttpGet]
        public IActionResult DepartmentWiseEmployeeDetails()
        {
            ViewBag.departments = new SelectList(_emp.GetDepartments(), "Did", "Dname");
            return View();
        }

        [HttpPost]
        public IActionResult DepartmentWiseEmployeeDetails(int DepartmentId)
        {
           var emp_departments=_emp.DepartmentWiseEmployeeDetails(DepartmentId);
           ViewBag.emp = emp_departments;
           ViewBag.departments = new SelectList(_emp.GetDepartments(), "Did", "Dname");
           return View();
        }
    }
}
