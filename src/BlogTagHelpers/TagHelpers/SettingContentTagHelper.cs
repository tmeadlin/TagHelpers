using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BlogTagHelpers.TagHelpers
{
    [HtmlTargetElement("content-example")]
    public class SettingContentTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var content = await output.GetChildContentAsync();
            var name = content.GetContent();

            output.Content.SetContent($"Hello, {name}");
        }
    }


    [HtmlTargetElement("content-example2")]
    public class SettingContent2TagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var content = await output.GetChildContentAsync();
            content.Append(", Hello World");

            output.Content = content;
        }
    }

    [HtmlTargetElement("content-example3")]
    public class SettingContent3TagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var content = await output.GetChildContentAsync();
            var name = content.GetContent();

            output.Content.SetHtmlContent($"Hello, <b>{name}</b>");
        }
    }
}
