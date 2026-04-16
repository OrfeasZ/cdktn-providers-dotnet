using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ShippingRate
{
    [JsiiInterface(nativeType: typeof(IShippingRateDeliveryEstimate), fullyQualifiedName: "stripe.shippingRate.ShippingRateDeliveryEstimate")]
    public interface IShippingRateDeliveryEstimate
    {
        /// <summary>maximum block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#maximum ShippingRate#maximum}
        /// </remarks>
        [JsiiProperty(name: "maximum", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMaximum\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum? Maximum
        {
            get
            {
                return null;
            }
        }

        /// <summary>minimum block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#minimum ShippingRate#minimum}
        /// </remarks>
        [JsiiProperty(name: "minimum", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMinimum\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ShippingRate.IShippingRateDeliveryEstimateMinimum? Minimum
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IShippingRateDeliveryEstimate), fullyQualifiedName: "stripe.shippingRate.ShippingRateDeliveryEstimate")]
        internal sealed class _Proxy : DeputyBase, stripe.ShippingRate.IShippingRateDeliveryEstimate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>maximum block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#maximum ShippingRate#maximum}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximum", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMaximum\"}", isOptional: true)]
            public stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum? Maximum
            {
                get => GetInstanceProperty<stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum?>();
            }

            /// <summary>minimum block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#minimum ShippingRate#minimum}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimum", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMinimum\"}", isOptional: true)]
            public stripe.ShippingRate.IShippingRateDeliveryEstimateMinimum? Minimum
            {
                get => GetInstanceProperty<stripe.ShippingRate.IShippingRateDeliveryEstimateMinimum?>();
            }
        }
    }
}
