using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ShippingRate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.shippingRate.ShippingRateDeliveryEstimateMaximum")]
    public class ShippingRateDeliveryEstimateMaximum : stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum
    {
        /// <summary>A unit of time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#unit ShippingRate#unit}
        /// </remarks>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        public string Unit
        {
            get;
            set;
        }

        /// <summary>Must be greater than 0.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#value ShippingRate#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }
    }
}
