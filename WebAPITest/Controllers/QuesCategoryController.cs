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
    public class QuesCategoryController : ApiController
    {
        private Category cat = new Category();
        public IEnumerable<QuestionCategory> Get()
        {
            return cat.GetCategory();
        }
    }
}
