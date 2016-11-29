using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BlogTagHelpers.TagHelpers
{
    [HtmlTargetElement("cart-total", Attributes = "cart-subtotal, cart-tax, cart-shipping")]
    public class CartTotalTagHelper : TagHelper
    {
        [HtmlAttributeName("cart-subtotal")]
        public decimal Subtotal { get; set; }

        [HtmlAttributeName("cart-tax")]
        public decimal Tax { get; set; }

        [HtmlAttributeName("cart-shipping")]
        public decimal Shipping { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var template = $@"<div class='form-group'>
                                <label class='col-md-6'>Subtotal:</label>
                                <div class='col-md-6'>
                                    <span class='form-control-static'>${Math.Round(Subtotal, 2)}</span> 
                                </div>                
                            </div>

                            <div class='form-group'>
                                <label class='col-md-6'>Tax:</label>
                                <div class='col-md-6'>
                                    <span class='form-control-static'>${Math.Round(Tax, 2)}</span> 
                                </div>                
                            </div>

                            <div class='form-group'>
                                <label class='col-md-6'>Shipping:</label>
                                <div class='col-md-6'>
                                    <span class='form-control-static'>${Math.Round(Shipping, 2)}</span> 
                                </div>                
                            </div>

                            <div class='form-group'>
                                <label class='col-md-6'>Total:</label>
                                <div class='col-md-6'>
                                    <span class='form-control-static'>${Math.Round(Subtotal + Tax + Shipping, 2)}</span> 
                                </div>                
                            </div>";

            output.TagName = "form";
            output.Attributes.Clear();
            output.Attributes.Add("class", "cart-totals form-horizontal");
            output.Content.SetHtmlContent(template);

        }
    }
}
