using System.Linq;
using System.Threading.Tasks;
using DancingGoat.Models;
using Microsoft.AspNetCore.Mvc;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Urls.Delivery.QueryParameters;
using System.Collections.Generic;

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

            foreach(var item in response.Item.Content)
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

            var viewModel = new HomePageViewModel
            {
                Articles = articles,
                Header = response.Item.HeroUnit.Cast<HeroUnit>().FirstOrDefault(x => x.System.Codename == "home_page_hero_unit"),
                Coffees = coffees
            };

            return View(viewModel);
        }

        public async Task<ActionResult> Spotlight()
        {
            var response = await _client.GetItemAsync<HomePage>("homepage", new LanguageParameter(Language), new DepthParameter(3));

            var coffees = new List<Coffee>();
            var articles = new List<Article>();

            foreach (var item in response.Item.Content)
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

            var viewModel = new HomePageViewModel
            {
                Articles = articles,
                Header = response.Item.HeroUnit.Cast<HeroUnit>().FirstOrDefault(x => x.System.Codename == "home_page_hero_unit"),
                Coffees = coffees
            };

            return View(viewModel);
        }
    }
}