// <auto-generated>
// This code was generated by a kontent-generators-net tool
// (see https://github.com/kontent-ai/model-generator-net).
//
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// For further modifications of the class, create a separate file with the partial class.
// </auto-generated>

using System;
using System.Collections.Generic;
using DancingGoat.Models;
using Kontent.Ai.Delivery.Abstractions;

namespace KontentAiModels
{
    public partial class Link
    {
        public const string Codename = "link";
        public const string AnchorLinkCodename = "anchor_link";
        public const string ExternalUrlCodename = "external_url";
        public const string IconCodename = "icon";
        public const string InternalLinkCodename = "internal_link";
        public const string LabelCodename = "label";
        public const string LinkTypeCodename = "link_type";

        public string AnchorLink { get; set; }
        public string ExternalUrl { get; set; }
        public IEnumerable<IAsset> Icon { get; set; }
        public IEnumerable<Page> InternalLink { get; set; }
        public string Label { get; set; }
        public IEnumerable<ITaxonomyTerm> LinkType { get; set; }
        public IContentItemSystemAttributes System { get; set; }
    }
}