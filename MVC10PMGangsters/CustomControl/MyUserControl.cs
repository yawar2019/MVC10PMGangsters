using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC10PMGangsters.CustomControl
{
    public static class MyUserControl
    {

        public static IHtmlString MyLabel(string content)
        {
            string htmlstring = String.Format("<label style='color:red'>{0}</label>", content);
            return new HtmlString(htmlstring);
        }

        public static IHtmlString createUrControl(this HtmlHelper helper, string content)
        {
            string htmlstring = "<input type=" + content + ">";
            return new HtmlString(htmlstring);
        }


    }
}