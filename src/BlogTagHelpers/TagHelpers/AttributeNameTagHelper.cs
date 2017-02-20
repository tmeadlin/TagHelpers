using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogTagHelpers.Models;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BlogTagHelpers.TagHelpers
{
    [HtmlTargetElement("attribute-example", Attributes = "to-name")]
    public class AttributeTagHelper : TagHelper
    {
        public string ToName { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.Content.SetContent($"Hello, {ToName}");
        }
    }

    [HtmlTargetElement("attribute-example2", Attributes = "to-name")]
    public class Attribute2TagHelper : TagHelper
    {
        [HtmlAttributeName("to-name")]
        public string Name { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.Content.SetContent($"Hello, {Name}");
        }
    }

    [HtmlTargetElement("attribute-example3")]
    public class Attribute3TagHelper : TagHelper
    {
        public double Price { get; set; }
        public ExampleModel Example { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.Content.SetContent($"Price Value: ${Price}. Example Text: {Example.Text}");
        }
    }
}
