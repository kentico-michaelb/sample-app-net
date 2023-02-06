using KontentAiModels;
using System.Collections.Generic;

namespace DancingGoat.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<Article> Articles { get; set; }

        public HeroUnit Header { get; set; }

        public IEnumerable<Coffee> Coffees { get; set; }
        public IEnumerable<CallToAction> CTAs { get; set; }
    }
}
