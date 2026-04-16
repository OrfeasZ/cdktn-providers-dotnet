using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.product.ProductMarketingFeatures")]
    public class ProductMarketingFeatures : stripe.Product.IProductMarketingFeatures
    {
        /// <summary>The marketing feature name. Up to 80 characters long.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#name Product#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
