using System.Linq;
using System.Threading.Tasks;
using DancingGoat.Models;
using Microsoft.AspNetCore.Mvc;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Urls.Delivery.QueryParameters;
using System.Collections.Generic;
using KontentAiModels;

namespace DancingGoat.Controllers
{
    public class HomepageController : ControllerBase
    {
        public HomepageController(IDeliveryClientFactory deliveryClientFactory) : base(deliveryClientFactory)
        {
        }


        public async Task<ActionResult> Index()
        {
            var response = await _client.GetItemAsync<HomePage>("homepage", new LanguageParameter(Language), new DepthParameter(3));

            var coffees = new List<Coffee>();
            var articles = new List<Article>();
            var ctas = new List<CallToAction>();

            foreach(var item in response.Item.Content)
            {
               
                if (item is Coffee)
                {
                    var coffee = item as Coffee;
                    coffees.Add(coffee);
                }
                else if (item is CallToAction)
                {
                    var cta = item as CallToAction;

                    //https://github.com/kontent-ai/delivery-sdk-net/blob/master/docs/customization-and-extensibility/strongly-typed-models.md#adding-support-for-runtime-type-resolution
                    var link_type = cta.Target.First().GetType();

                    if (link_type.Name == "InternalLink")
                    {
                        cta.Target.Cast<InternalLink>();
                    }
                    else
                    {
                        cta.Target.Cast<ExternalLink>();
                    }

                    ctas.Add(cta);
                }
                else
                {
                    var article = item as Article;
                    articles.Add(article);
                }
            }

            var viewModel = new HomePageViewModel
            {
                Articles = articles,
                Header = response.Item.HeroUnit.Cast<HeroUnit>().FirstOrDefault(x => x.System.Codename == "home_page_hero_unit"),
                Coffees = coffees,
                CTAs = ctas
            };

            return View(viewModel);
        }
    }
}