using MVCCrudAdo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrudAdo.Controllers
{
    public class UserController : Controller
    {
        UserDAL udal = new UserDAL();
        public ActionResult List()
        {
            var data= udal.GetUsers();

            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}