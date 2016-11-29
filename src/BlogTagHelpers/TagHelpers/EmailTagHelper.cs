using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BlogTagHelpers.TagHelpers
{
    //[HtmlTargetElement("span", Attributes = "product-name")]
    public class EmailTagHelper : TagHelper
    {        
        private const string EmailDomain = "contoso.com";

        // Can be passed via <email mail-to="..." />. 
        // Pascal case gets translated into lower-kebab-case.
        //public string MailTo { get; set; }

        //public override void Process(TagHelperContext context, TagHelperOutput output)
        //{
        //    output.TagName = "a";
        //    var address = $"{MailTo}@{EmailDomain}";
        //    output.Attributes.SetAttribute("href", $"mailto:{address}");
        //    output.Content.SetContent(address);
        //}

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + EmailDomain;
            //var address = $"{MailTo}@{EmailDomain}";
            output.Attributes.SetAttribute("href", $"mailto:{target}");
            output.Content.SetContent(target);
        }
    }
}
