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
    public partial class ExternalLink
    {
        public const string Codename = "external_link";
        public const string AbsoluteUrlCodename = "absolute_url";
        public const string OpenInNewTabCodename = "open_in_new_tab_";
        public const string PersonasCodename = "personas";

        public string AbsoluteUrl { get; set; }
        public IEnumerable<IMultipleChoiceOption> OpenInNewTab { get; set; }
        public IEnumerable<ITaxonomyTerm> Personas { get; set; }
        public IContentItemSystemAttributes System { get; set; }
    }
}