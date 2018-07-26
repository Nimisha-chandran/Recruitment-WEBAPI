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
            Category cat = new Category();
            //int SectionID=cat.getSectionID(ques.Section);
            ques1.SectionID = ques.SectionID;
            ques1.QuesDescription = ques.QuesDescription;
            
            db.tblQuestions.Add(ques1);
            db.SaveChanges();
            int newQuesID = ques1.QuestionID;

            //insert into QuesAns Table


            return "Congrats! Data Added.."+newQuesID;
        }

    }
}