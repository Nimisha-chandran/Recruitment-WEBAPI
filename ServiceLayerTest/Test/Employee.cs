using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLayerTest;

namespace ServiceLayerTest.Test
{
    public class Employee
    {
        Entities db = new Entities();

        public string insertEmployee(tblEmployee emp)
        {
            tblEmployee emp1 = new tblEmployee();
            emp1.EmployeeID = emp.EmployeeID;

            db.tblEmployee.Add(emp1);
            db.SaveChanges();

            return "Employee" + emp1.EmployeeID + "is Added Successfully";
        }
    }
}