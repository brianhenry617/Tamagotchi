using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class TamaController : Controller
    {
      [HttpGet("/Tama/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
    }
}
