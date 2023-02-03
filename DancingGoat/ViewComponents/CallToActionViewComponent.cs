using DancingGoat.Models;
using KontentAiModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;

namespace DancingGoat.ViewComponents
{
    public class CallToActionViewComponent : ViewComponent
    {

        public CallToActionViewComponent()
        {
        }

        public IViewComponentResult Invoke(CallToAction item)
        {
            return View(item);
        }
    }
}
