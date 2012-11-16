using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRDemo.Controllers
{
    [Authorize]
    public class NotifierController : Controller
    {
        //
        // GET: /MyDemo1/

        public ActionResult Index()
        {

            ViewBag.Suscriptions = Repository.GetSuscriptionsBySuscriber(User.Identity.Name);

            return View();
        }

    }
}
