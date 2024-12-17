using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeDirectory.DataLayer;

namespace EmployeeDirectory.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeeDao _employeeDao;

        public EmployeesController()
        {
            _employeeDao = new EmployeeDao();
        }
        // GET: Employees
        public ActionResult Index()
        {
            var empList = _employeeDao.GetAllEmployees();
            //var empList = Enumerable.Empty<Employee>();
            return View(empList);
        }


        public ActionResult Details(int? id)
        {
            var employee = _employeeDao.GetAllEmployees()
                .SingleOrDefault(e => e.Id == id);

            if (employee == null || id == 0)
                return new HttpNotFoundResult();

            return View(employee);
        }
    }
}