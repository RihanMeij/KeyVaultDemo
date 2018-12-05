using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeyVaultDemo.Models;
using KeyVaultDemo.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace KeyVaultDemo.Controllers
{
    public class SettingsController : Controller
    {
        private readonly IConfiguration configurationSimple;
        private readonly IOptions<KeyVaultOptions> complexSettings;

        public SettingsController(IConfiguration configurationSimple, IOptions<KeyVaultOptions> complexSettings)
        {
            this.configurationSimple = configurationSimple;
            this.complexSettings = complexSettings;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Simple()
        {
            return View(configurationSimple);
        }

        public IActionResult Complex()
        {
            return View(complexSettings);
        }

    }
}