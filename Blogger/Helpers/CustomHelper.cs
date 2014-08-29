using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blogger.Helpers
{
    public static class CustomHelper
    {

        public static MvcHtmlString CustomSubString(this HtmlHelper htmlHelper, string value)
        {
            if(value.Length>200)
            {
              value = value.Substring(0,200);
            }

            return MvcHtmlString.Create(value);
        }

    }
}