using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BlogTagHelpers.TagHelpers
{
    [HtmlTargetElement("image", Attributes = ImageName)]
    public class ImageTagHelper : TagHelper
    {
        private const string ImageName = "image-name";

        [HtmlAttributeName(ImageName)]
        public string Name { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";
            output.TagMode = TagMode.SelfClosing;
            output.Attributes.Clear();
            output.Attributes.Add("src", $"/images/{Name}-100.png");
        }
    }
}
