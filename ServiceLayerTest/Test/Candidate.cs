using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLayerTest;

namespace ServiceLayerTest.Test
{
    public class Candidate
    {
        private Entities db = new Entities();

        public string insertCandidates(tblCandidate cand)
        {
            tblCandidate cand1 = new tblCandidate();
            cand1.FirstName = cand.FirstName;
            cand1.LastName = cand.LastName;
            cand1.DOB = cand.DOB;
            cand1.EmailID = cand.EmailID;
            cand1.Experience = cand.Experience;
            cand1.Designation = cand.Designation;

            db.tblCandidate.Add(cand1);
            db.SaveChanges();

            int CandidateID = cand1.CandidateID;

            //insert into tblCandidate Table
            return "Congrats! Data Added Candidate with ID.." + CandidateID ;
        }
    }
}