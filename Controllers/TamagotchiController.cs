using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class TamaController : Controller
    {
      [Route("/Tama/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

      [Route("/index")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
