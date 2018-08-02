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
    public class CandidateController : ApiController
    {
        Candidate candidate = new Candidate();

        [HttpPost]
        public string InsertCandidate(tblCandidate cand)
        {
            return candidate.insertCandidates(cand);
        }

    }
}
