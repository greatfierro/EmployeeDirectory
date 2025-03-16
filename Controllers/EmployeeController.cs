using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeDirectory.DataLayer;
using EmployeeDirectory.ViewModels;

namespace EmployeeDirectory.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDao _employeeDao;
        public EmployeeController()
        {
            _employeeDao = new EmployeeDao();
        }
        // GET: Employee
        public ActionResult Index()
        {

            var empList = _employeeDao.GetAllEmployees()
                .Where(e => e.Employed)
                .ToList();


            List<EmpViewModel> viewModel = new List<EmpViewModel>();
            foreach (var e in empList)
                viewModel.Add(new EmpViewModel(e.Name,e.DateHired.ToString("MM/dd/yyyy"), e.Id));


            return View(viewModel);

        }

        [Route("employee/{id:int}")]
        public ActionResult Details(int id)
        {
            var emp = _employeeDao.GetAllEmployees().FirstOrDefault(e => e.Id == id);
            var model = new EmpViewModel(emp.Name, emp.DateHired.ToString("MM/dd/yyyy"), emp.Id);
            return View(model);
        }
    }
}
