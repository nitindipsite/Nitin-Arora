using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        // 1. Testing custom authorization attribute.
        [CustomAuthorizeAtrribute(false)]
        public string Index()
        {
            return "This is Index() action on the Home controller";
        }

        // 2a. Testing custom error attribute.
        [RangeException]
        public string RangeTest(int id)
        {
            if (id > 100)
            {
                return String.Format("The id value is: {0}", id);
            }
            else
            {
                throw new ArgumentOutOfRangeException("id", id, "");
            }
        }

        // 2b. Testing built in HandleError attribute to handle exceptions.
        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException), View = "RangeError")]
        public string RangeTestDefault(int id)
        {
            if (id > 100)
            {
                return String.Format("The id value is: {0}", id);
            }
            else
            {
                throw new ArgumentOutOfRangeException("id", id, "");
            }
        }

        // 3 and 4: Using IActionFilter and IResultFilter
        [ProfileAction]
        [ProfileResult]
        public string ActionFilterTest()
        {
            return @"This is ActionFilter Test";
        }

        // Same as above but done using inheriting ActionFilterAttribute
        [ProfileAll]
        public string FilterTest()
        {
            return "This is a filter test action";
        }

    }
}
