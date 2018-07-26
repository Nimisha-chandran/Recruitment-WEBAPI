using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiceLayerTest.Test;
using DataLayerTest;

namespace WebAPITest.Controllers
{
    public class AptitudeQuesController : ApiController
    {
        private IQuestionsTest Questest = new QuestionsTest();
       
        public IEnumerable<tblQuestions> Get()
        {
            return Questest.GetQuestions();
        }

        public tblQuestions GetQuestion(int id)
        {
            return Questest.GetQuestion(id);
        }

        [HttpPost]
        public string InsertQuestion(tblQuestions ques)
        {
            return Questest.insertQuestion(ques);
        }

    }
}
