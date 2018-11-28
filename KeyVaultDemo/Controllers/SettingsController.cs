using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeyVaultDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace KeyVaultDemo.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(ExampleViewModel data)
        {
            System.Diagnostics.Debug.Write(data);
            return Ok();
        }
    }
}