using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataLayerTest;
using ServiceLayerTest.Test;

namespace WebAPITest.Controllers
{
    public class ExistingEmployeeController : ApiController
    {

        Employee employee = new Employee();
        [HttpPost]
        public string InsertEmployee(tblEmployee emp)
        {
            return employee.insertEmployee(emp);
        }
    }
}
