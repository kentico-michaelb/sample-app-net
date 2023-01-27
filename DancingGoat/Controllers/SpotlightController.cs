using System.Linq;
using System.Threading.Tasks;
using DancingGoat.Models;
using Microsoft.AspNetCore.Mvc;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Urls.Delivery.QueryParameters;
using System.Collections.Generic;
using Kontent.Ai.Urls.Delivery.QueryParameters.Filters;
using KontentAiModels;

namespace DancingGoat.Controllers
{
    public class SpotlightController : ControllerBase
    {
        public SpotlightController(IDeliveryClientFactory deliveryClientFactory) : base(deliveryClientFactory)
        {
        }


        public async Task<ActionResult> Show(string id)
        {
            var response = await _client.GetItemsAsync<Page>(
                    new EqualsFilter("elements.url", id),
                    new LanguageParameter(Language), 
                    new DepthParameter(3)
                );

            Page page = response.Items.First();

            var coffees = new List<Coffee>();
            var articles = new List<Article>();
            var ctas = new List<CallToAction>();

            foreach(var item in page.Content)
            {
               
                if (item is Coffee)
                {
                    var coffee = item as Coffee;
                    coffees.Add(coffee);
                }
                else if (item is CallToAction)
                {
                    var cta = item as CallToAction;
                    // Add internal/external logic here??
                    ctas.Add(cta);
                }
                else
                {

                }
            }

            var viewModel = new PageViewModel
            {
                System = page.System,
                Articles = articles,
                Coffees = coffees,
                CTAs = ctas,
                Tone = page.Tone
            };

            return View(viewModel);
        }
    }
}