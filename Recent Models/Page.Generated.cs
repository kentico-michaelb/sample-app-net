// <auto-generated>
// This code was generated by a kontent-generators-net tool
// (see https://github.com/kontent-ai/model-generator-net).
//
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// For further modifications of the class, create a separate file with the partial class.
// </auto-generated>

using System;
using System.Collections.Generic;
using Kontent.Ai.Delivery.Abstractions;

namespace KontentAiModels
{
    public partial class Page
    {
        public const string Codename = "page";
        public const string ContentCodename = "content";
        public const string ShowInNavigationCodename = "show_in_navigation";
        public const string SubpagesCodename = "subpages";
        public const string TitleCodename = "title";
        public const string ToneCodename = "tone";
        public const string UrlCodename = "url";

        public IEnumerable<object> Content { get; set; }
        public IEnumerable<IMultipleChoiceOption> ShowInNavigation { get; set; }
        public IEnumerable<object> Subpages { get; set; }
        public IContentItemSystemAttributes System { get; set; }
        public string Title { get; set; }
        public IEnumerable<ITaxonomyTerm> Tone { get; set; }
        public string Url { get; set; }
    }
}