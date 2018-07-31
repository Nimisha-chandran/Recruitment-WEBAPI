using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebAPITest.Controllers
{
    public class DocFileController : ApiController
    {
        
        public string Post()

        {
            HttpResponseMessage result = null;
            var str ="";

            var httpRequest = HttpContext.Current.Request;

            if (httpRequest.Files.Count > 0)

            {

                var docfiles = new List<string>();

                foreach (string file in httpRequest.Files)

                {

                    var postedFile = httpRequest.Files[file];

                    var filePath = HttpContext.Current.Server.MapPath("~/" + postedFile.FileName);

                    postedFile.SaveAs(filePath);



                    docfiles.Add(filePath);

                }

                result = Request.CreateResponse(HttpStatusCode.Created, docfiles);
                str = result.Content.ReadAsStringAsync().Result;

            }

            else

            {

                result = Request.CreateResponse(HttpStatusCode.BadRequest);

            }

            return str;

        }
    }
}
