using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.Models;

namespace MVC.Controllers
{
    public class KendoController : Controller
    {
        private readonly ILogger<KendoController> _logger;

        public KendoController(ILogger<KendoController> logger)
        {
            _logger = logger;
        }

        public IActionResult DropDownList()
        {
            var stateList = new List<StateModel>
            {
                new StateModel { Name = "Gujarat", Code = "GJ" },
                new StateModel { Name = "Maharashtra", Code = "MH" },
                new StateModel { Name = "Rajasthan", Code = "RJ" },
                new StateModel { Name = "Telangana", Code = "TG" },
            };
            ViewBag.StateList = stateList;
            return View();
        }

        public IActionResult ComboBox()
        {
            return View();
        }

        public IActionResult RadioGroup()
        {
            return View();
        }

        public IActionResult CheckBoxGroup()
        {
            return View();
        }

        public IActionResult MultiSelect()
        {
            return View();
        }

        public IActionResult DatePicker()
        {
            return View();
        }

        public IActionResult DateTimePicker()
        {
            return View();
        }

        public IActionResult Upload()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Grid()
        {
            return View();
        }

        // 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}