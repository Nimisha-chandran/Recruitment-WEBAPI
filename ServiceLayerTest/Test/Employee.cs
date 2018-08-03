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

        public int insertEmployee(tblEmployee emp)
        {
            DataLayerTest.Test test = new DataLayerTest.Test();
            tblEmployee emp1 = new tblEmployee();
            emp1.EmployeeID = emp.EmployeeID;
            bool exists = (from employee in db.tblEmployee
                           where employee.EmployeeID == emp1.EmployeeID
                           select employee).Any();
            if (exists)
            {
                return  0 ;
            }

            else
            {
                db.tblEmployee.Select(e => e.EmployeeID == emp1.EmployeeID);
                db.tblEmployee.Add(emp1);
                db.SaveChanges();
                int? TestID = db.Test.Max(u => (int?)u.TestID);
                if (TestID != null)
                {
                    test.TestID = Convert.ToInt16(TestID + 1);
                }
                else
                {
                    test.TestID = 1;
                }

                test.Emp_Cand_ID = Convert.ToString(emp1.EmployeeID);
                test.QuesCategoryID = 1;//1 hardcorded for Logical Section bcz by default first question will be Logical.
                db.Test.Add(test);
                db.SaveChanges();

                return test.TestID;
            }
            
        }
    }
}