using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Price
{
    [JsiiByValue(fqn: "stripe.price.PriceCustomUnitAmount")]
    public class PriceCustomUnitAmount : stripe.Price.IPriceCustomUnitAmount
    {
        /// <summary>The maximum unit amount the customer can specify for this item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#maximum Price#maximum}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Maximum
        {
            get;
            set;
        }

        /// <summary>The minimum unit amount the customer can specify for this item. Must be at least the minimum charge amount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#minimum Price#minimum}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Minimum
        {
            get;
            set;
        }

        /// <summary>The starting unit amount which can be updated by the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#preset Price#preset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Preset
        {
            get;
            set;
        }
    }
}
