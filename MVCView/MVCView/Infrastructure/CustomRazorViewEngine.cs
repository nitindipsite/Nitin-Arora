using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCView.Infrastructure
{
    // Inheriting from RazorViewEngine to change the location of where MVC looks for
    // views.
    public class CustomRazorViewEngine : RazorViewEngine
    {
        public CustomRazorViewEngine()
        {
            ViewLocationFormats = new string[] { "/Views/{1}/{0}.cshtml", "/Views/Common/{0}.cshtml" };
        }
    }
}