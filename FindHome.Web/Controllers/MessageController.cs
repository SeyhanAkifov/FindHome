using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindHome.Web.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
