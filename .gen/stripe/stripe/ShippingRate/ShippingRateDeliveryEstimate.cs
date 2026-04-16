using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ShippingRate
{
    [JsiiByValue(fqn: "stripe.shippingRate.ShippingRateDeliveryEstimate")]
    public class ShippingRateDeliveryEstimate : stripe.ShippingRate.IShippingRateDeliveryEstimate
    {
        /// <summary>maximum block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#maximum ShippingRate#maximum}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximum", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMaximum\"}", isOptional: true)]
        public stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum? Maximum
        {
            get;
            set;
        }

        /// <summary>minimum block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#minimum ShippingRate#minimum}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimum", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMinimum\"}", isOptional: true)]
        public stripe.ShippingRate.IShippingRateDeliveryEstimateMinimum? Minimum
        {
            get;
            set;
        }
    }
}
