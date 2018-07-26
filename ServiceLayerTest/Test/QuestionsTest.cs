using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLayerTest;

namespace ServiceLayerTest.Test
{
    public class QuestionsTest:IQuestionsTest
    {
        //Connection will be initialized
        private Entities db = new Entities();
        public List<tblQuestions> GetQuestions()
        {
            return db.tblQuestions.ToList();
        }

        public tblQuestions GetQuestion(int QuesID)
        {
            return db.tblQuestions.Where(x => x.QuestionID == QuesID).FirstOrDefault();
        }

        public string insertQuestion(tblQuestions ques)
        {
            Entities db = new Entities();
            tblQuestions ques1 = new tblQuestions();

            //gets the Sections ID from QuestionCategory Dataset
            Category cat = new Category();
            int SectionID=cat.getSectionID(ques.Section);

            ques1.SectionID =Convert.ToInt16(SectionID);
            ques1.QuesDescription = ques.QuesDescription;
            ques1.AnsOption1 = ques.AnsOption1;
            ques1.AnsOption2 = ques.AnsOption2;
            ques1.AnsOption3 = ques.AnsOption3;
            ques1.AnsOption4 = ques.AnsOption4;
            ques1.CorrectAns = ques.CorrectAns;

            db.tblQuestions.Add(ques1);
            db.SaveChanges();
            int newQuesID = ques1.QuestionID;

            //insert into QuesAns Table


            return "Congrats! Data Added.."+newQuesID+"th record added!";
        }

    }
}