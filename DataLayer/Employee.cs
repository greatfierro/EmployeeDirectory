using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDirectory.DataLayer
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Employed { get; set; }
        public DateTime DateHired { get; set; }

    

    }


    public class EmployeeDao
    {


        private IEnumerable<Employee> _employees;

        public EmployeeDao()
        {
            _employees = new List<Employee>()
            {
                new Employee()
                    { Id = 1, DateHired = DateTime.Parse("11/02/2001"), Name = "Frank OCean", Employed = true },
                new Employee()
                    { Id = 2, DateHired = DateTime.Parse("01/01/2013"), Name = "Alex Gred", Employed = false },
                new Employee()
                    { Id = 3, DateHired = DateTime.Parse("03/15/2014"), Name = "Jessica Blue", Employed = true },
                new Employee()
                    { Id = 4, DateHired = DateTime.Parse("06/20/2015"), Name = "Michael Lee", Employed = false },
                new Employee()
                    { Id = 5, DateHired = DateTime.Parse("09/10/2016"), Name = "Sarah Park", Employed = true },
                new Employee()
                    { Id = 6, DateHired = DateTime.Parse("12/05/2017"), Name = "David Smith", Employed = false },
                new Employee()
                    { Id = 7, DateHired = DateTime.Parse("02/28/2018"), Name = "Emily Jones", Employed = true },
                new Employee()
                    { Id = 8, DateHired = DateTime.Parse("08/19/2019"), Name = "Brian White", Employed = true },
                new Employee()
                    { Id = 9, DateHired = DateTime.Parse("11/11/2020"), Name = "Olivia Green", Employed = false },
                new Employee()
                    { Id = 10, DateHired = DateTime.Parse("04/25/2021"), Name = "James Brown", Employed = true },
                new Employee()
                    { Id = 11, DateHired = DateTime.Parse("07/13/2022"), Name = "Sophia Black", Employed = false },
                new Employee()
                    { Id = 12, DateHired = DateTime.Parse("05/18/2023"), Name = "Ethan Miller", Employed = true },

            };
        }



        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employees;
        }


    }
}