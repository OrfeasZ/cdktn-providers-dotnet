using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ShippingRate
{
    [JsiiInterface(nativeType: typeof(IShippingRateDeliveryEstimateMaximum), fullyQualifiedName: "stripe.shippingRate.ShippingRateDeliveryEstimateMaximum")]
    public interface IShippingRateDeliveryEstimateMaximum
    {
        /// <summary>A unit of time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#unit ShippingRate#unit}
        /// </remarks>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        string Unit
        {
            get;
        }

        /// <summary>Must be greater than 0.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#value ShippingRate#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IShippingRateDeliveryEstimateMaximum), fullyQualifiedName: "stripe.shippingRate.ShippingRateDeliveryEstimateMaximum")]
        internal sealed class _Proxy : DeputyBase, stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A unit of time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#unit ShippingRate#unit}
            /// </remarks>
            [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
            public string Unit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Must be greater than 0.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#value ShippingRate#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
