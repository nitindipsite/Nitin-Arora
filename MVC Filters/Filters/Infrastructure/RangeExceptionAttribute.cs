using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Infrastructure
{
    // To define a custom filter, it should implement "FilterAttribute" which in turn implements IMVCFilter.
    public class RangeExceptionAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            // If the exception is not already handled and is of a given type.
            if (context.ExceptionHandled == false &&
                context.Exception is ArgumentOutOfRangeException)
            {
                // Setup the Result and mark it handled.
                context.Result = new RedirectResult("~/Content/RangeErrorPage.html");
                context.ExceptionHandled = true;
            }
        }
    }
}