using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceExample2
{
    /// <summary>
    /// Summary description for Multiplier
    /// </summary>
    [WebService(Namespace = "http://abc.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Multiplier : System.Web.Services.WebService
    {

        [WebMethod]
        public int multyplyNums(int a, int b, int c, int d, int e)
        {
            return a * b * c * d * e;
        }

        
    }
}
