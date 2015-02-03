using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        // Because ProfileAll is now registered in the global filter collection, it gets applied to all the actions
        // automatically.
        public string Index()
        {
            return "This is the customer controller";
        }

    }
}
