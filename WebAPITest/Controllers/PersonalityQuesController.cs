﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataLayerTest;
using ServiceLayerTest.Test;

namespace WebAPITest.Controllers
{
    public class PersonalityQuesController : ApiController
    {
        private PersonalityQues PQuestest = new PersonalityQues();

        public IEnumerable<tblPersonalityQues> Get()
        {
            return PQuestest.GetPersonalityQuestions();
        }

    }
}
