using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLayerTest;

namespace ServiceLayerTest.Test
{
    
    public class Category
    {
        private Entities db = new Entities();   
        public int getSectionID(string section)
        {
            int CategoryID=0;

            IEnumerable<int> query = from i in db.QuestionCategory.AsEnumerable()
                                       where i.CategoryDescription == section
                                     select i.CategoryId;
            foreach (int id in query)
            {
                 CategoryID = id;
            }

            return CategoryID;


        }

    }
}