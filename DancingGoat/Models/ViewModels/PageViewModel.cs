using Kontent.Ai.Delivery.Abstractions;
using KontentAiModels;
using System.Collections.Generic;

namespace DancingGoat.Models
{
    public class PageViewModel
    {
        public IContentItemSystemAttributes System { get; set; }
        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable<Coffee> Coffees { get; set; }
        public IEnumerable<CallToAction> CTAs { get; set; }
        public IEnumerable<ITaxonomyTerm> Tone { get; set; }
    }
}
