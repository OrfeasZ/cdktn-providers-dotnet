using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    [JsiiByValue(fqn: "stripe.product.ProductTaxDetails")]
    public class ProductTaxDetails : stripe.Product.IProductTaxDetails
    {
        /// <summary>The ID of a tax location with type `performance`, representing where the performance takes place.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product#performance_location Product#performance_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "performanceLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PerformanceLocation
        {
            get;
            set;
        }

        /// <summary>A [tax code](https://docs.stripe.com/tax/tax-categories) ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product#tax_code Product#tax_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taxCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaxCode
        {
            get;
            set;
        }
    }
}
