using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Price
{
    [JsiiByValue(fqn: "stripe.price.PriceProductDataTaxDetails")]
    public class PriceProductDataTaxDetails : stripe.Price.IPriceProductDataTaxDetails
    {
        /// <summary>A tax location ID. Depending on the [tax code](/tax/tax-for-tickets/reference/tax-location-performance), this is required, optional, or not supported.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/price#performance_location Price#performance_location}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/price#tax_code Price#tax_code}
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
