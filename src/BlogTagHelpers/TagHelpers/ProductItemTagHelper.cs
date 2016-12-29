using BlogTagHelpers.Core.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BlogTagHelpers.TagHelpers
{    
    [HtmlTargetElement("product-item", Attributes = "item")]
    public class ProductItemTagHelper : TagHelper
    {      
        public ProductItem Item { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class", "product-item");

            output.Content.SetHtmlContent(ProductItemContent());           
        }

        private string ProductItemContent()
        {
            return $@"<div class='row'>
                                <div class='col-md-12'>
                                    <img src = 'images/{Item.ImageName}-300.png' class='pull-left' />
                                </div>
                            </div>

                            <div class='row title'>
                                <div class='col-md-8'>
                                    <label>{Item.Name}</label>
                                </div>
                                <div class='col-md-4'>
                                    <label>${Item.Price}</label>
                                </div>
                            </div>

                            <div class='row'>
                                <div class='col-md-12'>
                                    <span>{Item.Description}</span>
                                </div>
                            </div>";
        }
    }
}
