using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLayerTest;

namespace ServiceLayerTest.Test
{
    public class PersonalityQues
    {
        private Entities db = new Entities();
        public List<tblPersonalityQues> GetPersonalityQuestions()
        {
            return db.tblPersonalityQues.ToList();
        }
    }
}