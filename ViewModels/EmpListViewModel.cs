using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDirectory.ViewModels
{
    public class EmpViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HiredDate { get; set; }

        public EmpViewModel(string name, string hiredDate, int id)
        {
            this.Name = name;
            this.HiredDate = hiredDate;
            this.Id = id;
        }
    }
}