using System.Linq;
using System.Threading.Tasks;
using DancingGoat.Models;
using Microsoft.AspNetCore.Mvc;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Urls.Delivery.QueryParameters;
using System.Collections.Generic;
using Kontent.Ai.Urls.Delivery.QueryParameters.Filters;

namespace DancingGoat.Controllers
{
    public class SpotlightController : ControllerBase
    {
        public SpotlightController(IDeliveryClientFactory deliveryClientFactory) : base(deliveryClientFactory)
        {
        }


        public async Task<ActionResult> Index(string urlSlug)
        {
            var response = await _client.GetItemsAsync<Page>(
                    new EqualsFilter("elements.url", urlSlug),
                    new LanguageParameter(Language), 
                    new DepthParameter(3)
                );

            Page page = response.Items.First();

            var coffees = new List<Coffee>();
            var articles = new List<Article>();

            foreach(var item in page.Content)
            {
               
                if (item is Coffee)
                {
                    var coffee = item as Coffee;
                    coffees.Add(coffee);
                }
                else
                {
                    var article = item as Article;
                    articles.Add(article);
                }
            }

            var viewModel = new PageViewModel
            {
                System = page.System,
                Articles = articles,
                Coffees = coffees,
                Tone = page.Tone
            };

            return View(viewModel);
        }
    }
}