using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ShippingRate
{
    [JsiiInterface(nativeType: typeof(IShippingRateDeliveryEstimate), fullyQualifiedName: "stripe.shippingRate.ShippingRateDeliveryEstimate")]
    public interface IShippingRateDeliveryEstimate
    {
        /// <summary>maximum block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/shipping_rate#maximum ShippingRate#maximum}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "maximum", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMaximum\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Maximum
        {
            get
            {
                return null;
            }
        }

        /// <summary>minimum block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/shipping_rate#minimum ShippingRate#minimum}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.ShippingRate.IShippingRateDeliveryEstimateMinimum" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "minimum", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMinimum\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Minimum
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/shipping_rate#maximum ShippingRate#maximum}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximum", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMaximum\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Maximum
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>minimum block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/shipping_rate#minimum ShippingRate#minimum}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.ShippingRate.IShippingRateDeliveryEstimateMinimum" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimum", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMinimum\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Minimum
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
