// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery.Abstractions;

namespace KenticoKontentModels
{
    public partial class Tweet
    {
        public const string Codename = "tweet";
        public const string DisplayOptionsCodename = "display_options";
        public const string ThemeCodename = "theme";
        public const string TweetLinkCodename = "tweet_link";

        public IEnumerable<MultipleChoiceOption> DisplayOptions { get; set; }
        public ContentItemSystemAttributes System { get; set; }
        public IEnumerable<MultipleChoiceOption> Theme { get; set; }
        public string TweetLink { get; set; }
    }
}