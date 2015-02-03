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
        [CustomAuthorizeAtrribute(false)]
        public string Index()
        {
            return "This is Index() action on the Home controller";
        }

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

        [ProfileAll]
        public string FilterTest()
        {
            return "This is a filter test action";
        }
    }
}
