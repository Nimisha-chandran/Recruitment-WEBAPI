using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiceLayerTest.Test;
using DataLayerTest;
using System.Web.Http.Description;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace WebAPITest.Controllers
{
    public class CandidateController : ApiController
    {
        Entities db = new Entities();
        Candidate candidate = new Candidate();

        [HttpPost]
        public int InsertCandidate(tblCandidate cand)
        {
            return candidate.insertCandidates(cand);
           
        }

        [ResponseType(typeof(void))]
        public IHttpActionResult PutScore(DataLayerTest.Test test)
        {

            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            //using (var ctx = new Test())
            //{
                var existingScore = db.Test.Where(s => s.TestID == test.TestID && s.QuesCategoryID==test.QuesCategoryID).FirstOrDefault<Test>() ;

                if (existingScore.Score == null)
                {
                    existingScore.Score = test.Score;
                    //existingStudent.LastName = student.LastName;

                    db.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            //}

            return Ok();
        }

        //public string UpdateScore(Test test)
        //{
        //    return candidate.UpdateScore(test);
        //}

    }
}
