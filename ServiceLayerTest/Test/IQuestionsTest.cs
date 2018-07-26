using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerTest;

namespace ServiceLayerTest.Test
{
    public interface IQuestionsTest
    {
        List<tblQuestions> GetQuestions();
        tblQuestions GetQuestion(int QuesID);

        string insertQuestion(tblQuestions ques);
    }
}
