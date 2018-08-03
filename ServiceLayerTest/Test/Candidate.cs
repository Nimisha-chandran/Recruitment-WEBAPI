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
            DataLayerTest.Test test = new DataLayerTest.Test();
            cand1.FirstName = cand.FirstName;
            cand1.LastName = cand.LastName;
            cand1.DOB = cand.DOB;
            cand1.EmailID = cand.EmailID;
            cand1.Experience = cand.Experience;
            cand1.Designation = cand.Designation;
            
            
            db.tblCandidate.Add(cand1);
            db.SaveChanges();

            int? TestID = db.Test.Max(u => (int?)u.TestID);
            if (TestID!=null)
            {
                test.TestID = Convert.ToInt16(TestID + 1);
            }
            else
            {
                test.TestID = 1;
            }
             
            test.Emp_Cand_ID = Convert.ToString(cand1.CandidateID);
            test.QuesCategoryID = 1;//1 hardcorded for Logical Section bcz by default first question will be Logical.
            db.Test.Add(test);
            db.SaveChanges();

            int TestID1 = test.TestID;
            
            //insert into tblCandidate Table
            return "Congrats! Data Added Candidate with ID.." + TestID1;
        }

        //public string UpdateScore(DataLayerTest.Test test)
        //{
        //    DataLayerTest.Test test1 = new DataLayerTest.Test();
        //    test1.TestID = test.TestID;
        //    test1.Emp_Cand_ID = test.Emp_Cand_ID;
        //    test1.QuesCategoryID = test.QuesCategoryID;
        //    test1.Score = test.Score;

        //    db.Test
        //}



    }
}