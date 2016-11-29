using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BlogTagHelpers.TagHelpers
{
    [HtmlTargetElement("span", Attributes = LimitTo)]
    public class LimitTextTagHelper : TagHelper
    {
        private const string LimitTo = "limit-to";

        [HtmlAttributeName(LimitTo)]
        public int MaxLength { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var text = (await output.GetChildContentAsync()).GetContent();

            if (string.IsNullOrEmpty(text) || text.Length <= MaxLength)
                return;
            
            output.Content.SetContent($"{text.Substring(0, MaxLength)}...");
        }
    }
}
