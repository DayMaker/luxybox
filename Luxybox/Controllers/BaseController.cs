using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Luxybox.Controllers
{
    public class BaseController : Controller
    {
        protected Data.LuxyBoxEntities dbContext = null;
        protected override void Initialize(RequestContext requestContext)
        {
            dbContext = new Data.LuxyBoxEntities();
            base.Initialize(requestContext);
        }
        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
            base.Dispose(disposing);
        }
    }
}