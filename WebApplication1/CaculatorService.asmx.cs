using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for CaculatorService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CaculatorService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int MyCalc(int a,int b,int c,char choice)
        {
            int result=0;
            switch (choice) {
                case '+':
                    result = a + b+c;
                    break;

                case '-':
                    result = a - b-c;
                    break;
                case '%':
                    result = a / b*c;
                    break;
                case '*':
                    result = a * b*a;
                    break;
            }
            return result;
        }
    }
}
